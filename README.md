**Pogoda**

Aplikacja do pobierania pogody dla danego miejsca

# Technologie
-MAUI

-WeatherApi

# Co pokazuje aplikacja?
Aplikacja pokazuje dla danego miejsca:

-Temperaturę

-Opady

-Wiatr

-Poziom Zachmurzenia

-Wilgoć

# Jak aplikacja została napisana?

Do łączenia się z API wykorzystaliśmy HttpClient
https://github.com/kube3qq/Litawka/blob/502fa4d599103f05a7e260042ede33548d4485b8/Services/ApiServices.cs#L11-L26

Wszystkie dane są przesyłane w formacie JSON, a następnie parsowane i wklejane do widoku za pomocą Newtonsoft.Json

Widok jest napisany na Gridach, StackLayoutach oraz CollectionView
https://github.com/kube3qq/Litawka/blob/502fa4d599103f05a7e260042ede33548d4485b8/WeatherPage.xaml#L6-L93

## Screen
Kubuś tutaj jak wrzucisz te screeny to mi tutaj powrzucaj linki do tych screenów tak jak tutaj żeby się fajnie wyświetlały i gotowe będzie
![](https://github.com/pengwius/WpfPogoda/blob/main/img/paszyn.png)

## Zepsuł
Cięciwa
