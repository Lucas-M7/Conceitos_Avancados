/*
Implementar um sistema de alarme 
que detecta quando a temperatura de uma sala excede um certo limite. 
Quando isso acontecer, um evento deve ser disparado 
para notificar que a temperatura está alta
*/

using Challenge.Models;

Thermometer thermometer = new() { TemperatureLimit = 30.0 };
Alarm alarm = new();

thermometer.TemperatureExceeded += alarm.OnTemperatureExceeded;

thermometer.Temperature = 31.0;
thermometer.CheckTemperature();