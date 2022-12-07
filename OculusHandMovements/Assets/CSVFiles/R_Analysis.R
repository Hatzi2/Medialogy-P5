library(ggplot2)
library(moments)
library(dplyr)
PosX <- output$PosX
PosY <- output$PosY
count <- abs(rnorm(output$Count))


df <- output




plot <- ggplot(df) +  geom_point(aes(x = PosX, y= PosY, color = count))+
  geom_raster(aes(fill = count)) +
  scale_fill_gradientn(colours = terrain.colors(100))
plot+scale_color_gradient(low="blue", high="red")


plot2 <- ggplot(df, aes(PosX, PosY), fill = count) +
  geom_raster(aes(fill = count)) +
  scale_fill_gradientn(colours = heat.colors(10, rev = TRUE))
plot2