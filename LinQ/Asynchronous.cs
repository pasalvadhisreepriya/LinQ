using System;
public class Asynchronous{
public async void LongProcess()
{
    Console.WriteLine("LongProcess Started");

    await Task.Delay(4000);

    Console.WriteLine("LongProcess Completed");

}

public void ShortProcess() {
    Console.WriteLine("ShortProcess Started");
            
    Console.WriteLine("ShortProcess Completed");    
}
}