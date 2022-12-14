library(ggplot2)
library(moments)
library(dplyr)
PosX <- OurResults$PosX
PosY <- OurResults$PosY
Count <- abs(rnorm(OurResults$Count))
PosXAdjusted <- OurResultsAdjusted$PosX
PosYAdjusted <- OurResultsAdjusted$PosY
count <- OurResultsAdjusted$Count
PosXGuardianAdjusted <- GuardianResultsAdjusted$PosX
PosYGuardianAdjusted <- GuardianResultsAdjusted$PosY
count <- GuardianResultsAdjusted$Count


df <- OurResults
AdjustedResults <- OurResultsAdjusted
AdjustedGuardianResults <- GuardianResultsAdjusted

plotGuardianAdjusted <- ggplot(AdjustedGuardianResults, aes(PosXGuardianAdjusted, PosYGuardianAdjusted), fill = count) +
  geom_raster(aes(fill = count)) +
  scale_fill_gradientn(colours = heat.colors(10, rev = TRUE))
plotGuardianAdjusted


plotAdjusted <- ggplot(AdjustedResults, aes(PosXAdjusted, PosYAdjusted), fill = count) +
  geom_raster(aes(fill = count)) +
  scale_fill_gradientn(colours = heat.colors(10, rev = TRUE))
plotAdjusted

plot2 <- ggplot(df, aes(PosX, PosY), fill = count) +
  geom_raster(aes(fill = count)) +
  scale_fill_gradientn(colours = heat.colors(10, rev = TRUE))
plot2

dfG <- GuardianResults
PosXGuardian <- GuardianResults$PosX
PosYGuardian <- GuardianResults$PosY
count <- GuardianResults$Count

plotGuardian <- ggplot(dfG, aes(PosXGuardian, PosYGuardian), fill = count) +
  geom_raster(aes(fill = count)) +
  scale_fill_gradientn(colours = heat.colors(10, rev = TRUE))
plotGuardian

dfA <- TotalResults
PosXAll <- TotalResults$PosX
PosYAll <- TotalResults$PosY
CountAll <- TotalResults$Count

plotGuardian <- ggplot(dfA, aes(PosXAll, PosYAll), fill = CountAll) +
  geom_raster(aes(fill = CountAll)) +
  scale_fill_gradientn(colours = heat.colors(10, rev = TRUE))
plotGuardian


test1Time <- tail(Test_1$Time.,n=1)
test2Time <- tail(Test_2$Time.,n=1)
test3Time <- tail(Test_3$Time.,n=1)
test4Time <- tail(Test_4$Time.,n=1)
test5Time <- tail(Test_5$Time.,n=1)
test6Time <- tail(Test_6$Time.,n=1)
test7Time <- tail(Test_7$Time.,n=1)
test8Time <- tail(Test_8$Time.,n=1)
test9Time <- tail(Test_9$Time.,n=1)
test10Time <- tail(Test_10$Time.,n=1)
test11Time <- tail(Test_11$Time.,n=1)
test12Time <- tail(Test_12$Time.,n=1)
test13Time <- tail(Test_13$Time.,n=1)
test14Time <- tail(Test_14$Time.,n=1)
test15Time <- tail(Test_15$Time.,n=1)
df10 <- data.frame(TestNumber=c("Test1","Test2","Test3","Test4","Test5","Test6","Test7","Test8","Test9","Test10","Test11","Test12","Test13","Test14","Test15"), TimeInSeconds=c(test1Time, test2Time, test3Time, test4Time, test5Time,test6Time, test7Time, test8Time, test9Time, test10Time, test11Time, test12Time, test13Time, test14Time, test15Time))
meanOurs <- mean(df10$TimeInSeconds)
medianOurs <- median(df10$TimeInSeconds)

df10A <- data.frame(TestNumber=c("Test4","Test5","Test6","Test7","Test8","Test9","Test10","Test11","Test12","Test13","Test14","Test15"), TimeInSeconds=c(test4Time, test5Time,test6Time, test7Time, test8Time, test9Time, test10Time, test11Time, test12Time, test13Time, test14Time, test15Time))
meanOurs <- mean(df10A$TimeInSeconds)
medianOurs <- median(df10A$TimeInSeconds)

test16Time <- tail(Test_16$Time.,n=1)
test17Time <- tail(Test_17$Time.,n=1)
test18Time <- tail(Test_18$Time.,n=1)
test19Time <- tail(Test_19$Time.,n=1)
test20Time <- tail(Test_20$Time.,n=1)
test21Time <- tail(Test_21$Time.,n=1)
test22Time <- tail(Test_22$Time.,n=1)
test23Time <- tail(Test_23$Time.,n=1)
test24Time <- tail(Test_24$Time.,n=1)
test25Time <- tail(Test_25$Time.,n=1)
test26Time <- tail(Test_26$Time.,n=1)
test27Time <- tail(Test_27$Time.,n=1)
test28Time <- tail(Test_28$Time.,n=1)
test29Time <- tail(Test_29$Time.,n=1)
test30Time <- tail(Test_30$Time.,n=1)
df11 <- data.frame(TestNumber=c("Test16","Test17","Test18","Test19","Test20","Test21","Test22","Test23","Test24","Test25","Test26","Test27","Test28","Test29","Test30"),TimeInSeconds=c(test16Time, test17Time, test18Time, test19Time, test20Time,test21Time, test22Time, test23Time, test24Time, test25Time, test26Time, test27Time, test28Time, test29Time, test30Time))
meanGuard <- mean(df11$TimeInSeconds)
medianGuard <- median(df11$TimeInSeconds)

df11A <- data.frame(TestNumber=c("Test16","Test17","Test18","Test19","Test20","Test21","Test22","Test23","Test24","Test25","Test26","Test27","Test29","Test30"),TimeInSeconds=c(test16Time, test17Time, test18Time, test19Time, test20Time,test21Time, test22Time, test23Time, test24Time, test25Time, test26Time, test27Time, test29Time, test30Time))
meanGuard <- mean(df11A$TimeInSeconds)
medianGuard <- median(df11A$TimeInSeconds)


bars <- ggplot(data=df10,aes(x=TestNumber ,y=TimeInSeconds))+
  geom_bar(stat="identity", color = "blue", fill = rgb(0,0,0.7,0.7))+
  geom_hline(yintercept = 900)
bars
barsG <- ggplot(data=df11,aes(x=TestNumber ,y=TimeInSeconds))+
  geom_bar(stat="identity", color = "red", fill = rgb(0.7,0,0,0.7))+
  geom_hline(yintercept = 900)
barsG

AllOurTimes <- data.frame(Time=c(Test_1$Time., Test_2$Time.,Test_3$Time.,Test_4$Time.,Test_5$Time.,Test_6$Time.,Test_7$Time.,Test_8$Time.,Test_9$Time.,Test_10$Time.,Test_11$Time.,Test_12$Time.,Test_13$Time.,Test_14$Time.,Test_15$Time.))

AllGuardianTimes <- data.frame(Time=c(Test_16$Time., Test_17$Time.,Test_18$Time.,Test_19$Time.,Test_20$Time.,Test_21$Time.,Test_22$Time.,Test_23$Time.,Test_24$Time.,Test_25$Time.,Test_26$Time.,Test_27$Time.,Test_28$Time.,Test_29$Time.,Test_30$Time.))

Willtest <- wilcox.test(AllOurTimes$Time, AllGuardianTimes$Time,  data = DS, exact = FALSE)


