using System;
// Kelub Thorn
// IT112
// NOTES: Once completed this assignment was easy to understand.
// In total it only took me about an hour of coding to complete it.
// The hardest part for me was understanding the directions.
// I realized I have a horrible issue with understanding terms for coding stuff.
// I can identify what it is and what its used for but I don't know the name of things.
// Any tips regarding this would be appreciated because it made this assignment twice as hard.
// BEHAVIORS NOT IMPLIMENTED AND WHY: All Behaviours implimented. The formatting may not be implemented but I believe it is implemented correctly.
namespace Thorn_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] p = new Phone[10];
            p[0] = new Homephone("CompuTest", "(303) 985-5060", "1");
            p[1] = new Cellphone("Curtis Manufacturing", "(603) 523-4123", "2");
            p[2] = new Homephone("Data Functions", "(800) 876-2524", "1");
            p[3] = new Homephone("Donnay Repair", "(708) 397-330", "1");
            p[4] = new Homephone("ErgoNomic Inc.", "(360) 434-3894", "1");
            p[5] = new Homephone("ErgoSource", "(800) 969-4374", "1");
            p[6] = new Cellphone("Fox Bay Industries", "(800) 874-8527", "2");
            p[7] = new Cellphone("Glare-Guard", "(800) 545-6254", "2");
            p[8] = new Cellphone("Hazard Comm Specialists", "(407) 783-6641", "2");
            p[9] = new Cellphone("Komfort Support", "(714) 472-4409", "2");
            for (int i = 0; i < 10; i++)
            {
                p[i].Dial();
            }
        }
                  
    }
}
