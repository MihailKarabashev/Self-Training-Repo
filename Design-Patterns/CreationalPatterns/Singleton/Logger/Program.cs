// See https://aka.ms/new-console-template for more information
using Logger;

var firstLogger = Logger.Logger.GetInstance();
var secoundLogger = Logger.Logger.GetInstance();

Console.WriteLine($"Are references equal: {firstLogger == secoundLogger}");


var firstLog = Log.Instance;
var secoundLog = Log.Instance;

Console.WriteLine($"Are references equal: {firstLog == secoundLog}");