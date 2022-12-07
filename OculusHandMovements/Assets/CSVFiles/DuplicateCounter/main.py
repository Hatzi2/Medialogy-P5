import pandas as pd
import numpy as np
from numpy import savetxt

df = pd.read_csv('TotalTests.csv', delimiter=";", decimal=",") #Read the data from csv file

PosX = df['PosX;'].to_numpy() #Isolate PosX and PosY
PosY = df['PosY;'].to_numpy()
Positions = np.vstack((PosX,PosY)).T #Stack all PosX on each other and PosY on each other
unique_rows, counts = np.unique(Positions, axis=0, return_counts=True) #Count all duplicates and then remove them leaving only one
countsV = np.vstack((counts)) #Make a new column with all counts next to their appropiate PosX and PosY values

SaveFile = np.concatenate((unique_rows,countsV), axis=1) #Set up a new array with PosX, PosY and Count
savetxt('TotalResults.csv', SaveFile, delimiter=";", fmt='%1.3f') #Save float to a CSV file
print(SaveFile)