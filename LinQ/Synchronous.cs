using System;
public class Synchronous
{
public void LongProcess()
{
    Console.WriteLine("LongProcess Started");
    System.Threading.Thread.Sleep(4000);

    Console.WriteLine("LongProcess Completed");
}

public void ShortProcess() {
    Console.WriteLine("ShortProcess Started");
            
    Console.WriteLine("ShortProcess Completed");    
}
}
     
 