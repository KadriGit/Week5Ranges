// 0 (or below) - freezin
// from 0 to 5 - cold
// from 5 to 10 - chilly
// from 10 to 15  - cool
// from 15 to 28 - warm
// above 28 - boilong hot

Console.WriteLine("Enter the current temp: ");
int currentTemp = Int32.Parse(Console.ReadLine());

if(currentTemp <= 0){
    Console.WriteLine("Freezing");
}
else if(currentTemp > 0 && currentTemp < 5){
    Console.WriteLine("Cold");
}
else if (currentTemp >= 5 && currentTemp < 10)
{
    Console.WriteLine("Chilly");
}
else if (currentTemp >= 10 && currentTemp < 15)
{
    Console.WriteLine("Cool");
}
else if (currentTemp >= 15 && currentTemp < 28)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("Boling hot");
}
