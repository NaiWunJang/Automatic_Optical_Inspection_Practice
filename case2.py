import cv2
import numpy as np
import RPi.GPIO as GPIO
import time
import subprocess

cam = cv2.VideoCapture('http://localhost:8080/?action=stream')

initFlag = True
firstFlag = False
flag = 0
previous = 5
pre_WhitePixel = 0
cropX = 0
cropY = 0
cropWidth = 0
cropHeight = 0

BUZZER_PIN = 23
LED_PIN = 24
INPUT_PIN = 22


def mse(imageA, imageB) :
    err = np.sum(imageA.astype["float"]-imageB.astype["float"] ** 2)
    err = err / float(imageA.shape[0] * imageB[1])
    return err 

try:
    
    while(cam.isOpened()) :
        
        if initFlag :
            print('Initalization...')
            CamWidth = cam.get(3)
            CamHeight = cam.get(4)
            outputFPS = cam.get(5)

            
            GPIO.setmode(GPIO.BCM)
            GPIO.setup(BUZZER_PIN, GPIO.OUT)
            GPIO.setup(LED_PIN, GPIO.OUT)
            GPIO.setup(INPUT_PIN, GPIO.IN)

            print('Output Property:')
            print('  Width', CamWidth, sep=' ')
            print('  Height', CamHeight, sep=' ')
            print('  FPS', outputFPS, sep=' ')
            print('------------------------')
            print('GPIO Setup:')
            print('  PIN_24:', GPIO.input(INPUT_PIN))
            ##print('PIN_'+OUT_PIN+': ')

            cropX = int(CamWidth/4)
            cropY = int(CamHeight/4)
            cropWidth = int(CamWidth/2)
            cropHeight = int(CamHeight/2)

            _, first = cam.read()
            crop = first[cropY:cropY+cropHeight, cropX:cropX+cropWidth]
            avg = cv2.blur(crop, (3,3))
            avgFloat = np.float32(avg)
            pre_WhitePixel = CamWidth * CamHeight

            initFlag = False

        while GPIO.input(INPUT_PIN) == 1 :
            
            print('Running...')

        if flag == previous:
            _, first = cam.read()
            crop = first[cropY:cropY+cropHeight, cropX:cropX+cropWidth]
            avg = cv2.blur(crop, (3,3))
            flag = 0
        else :
            flag += 1

        _, img = cam.read()

        cropImg = first[cropY:cropY+cropHeight, cropX:cropX+cropWidth]

        blur = cv2.blur(cropImg, (3,3))

        diff = cv2.absdiff(avg, cropImg)

        gray = cv2.cvtColor(diff, cv2.COLOR_BGR2GRAY)
         
        _, thresh = cv2.threshold(gray, 25, 255, cv2.THRESH_BINARY)

        kernel = np.ones((3,3),np.uint8)

        erosion = cv2.erode(thresh, kernel, iterations = 1)

##        print(cv2.countNonZero(thresh)-pre_WhitePixel-1000)
##        print('----')
        
        
##        if cv2.countNonZero(thresh) > pre_WhitePixel+150 :
##            GPIO.output(LED_PIN, True)
##            GPIO.output(BUZZER_PIN, True)
##            time.sleep(.1)
##            GPIO.output(LED_PIN, False)
##            time.sleep(2)
##            GPIO.output(BUZZER_PIN, False)
##            time.sleep(2)
##            
##            break
##        else :
##            pre_WhitePixel = cv2.countNonZero(thresh)
            
##        cv2.imshow('video2', diff)

##        cnts, cntImg = cv2.findContours(thresh, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE) 
##    
####        for c in cnts :
##            if cv2.contourArea(c) < 4000 :
##                continue
##            (x, y, w, h) = cv2.boundingRect(c)
##            cv2.rectangle(img, (x, y), (x+w, y+h), (0, 255, 0), 2)
##    
##        cv2.drawContours(img, cnts, -1, (0, 255, 255), 2)
        
        cv2.imshow('video0', img)

        cv2.accumulateWeighted(blur, avgFloat, 0.5)
        avg = cv2.convertScaleAbs(avgFloat)
        
        cv2.imshow('video1', thresh)
        
        
        if 0xFF & cv2.waitKey(1) == ord('q') :        
            break
        
    GPIO.cleanup()
    cv2.destroyAllWindows()
    print('breaking...')
##    subprocess.Popen('sudo python /home/pi/test/case2.py', shell = True)

except KeyboardInterrupt:
    print('Interrupution...')
    GPIO.cleanup()
    cv2.destroyAllWindows()
    quit()
