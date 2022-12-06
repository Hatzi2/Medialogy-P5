library(ggplot2)
library(moments)
library(dplyr)
mygraph = read.table("Test_1.csv", header = TRUE, sep=";")
PosX <- Test_1$PosX
PosY <- Test_1$PosY

df <- (subset(Test_1, select = -c(Name., Time.)))




ggplot(df) + geom_point(aes(x = PosX, y= PosY))