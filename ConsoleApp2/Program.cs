using System;

class FuzzyLogicCarSelection
{

    // Qeyri-selis mentiq funksiyasi
    static double FuzzyLogic(double fuelEfficiency, double safety, double cost)
    {
        // Qeyri-selis qaydalar (numayis ucun sade ortalama)
        //osduraq
        double rule1 = Math.Min(fuelEfficiency, Math.Min(safety, cost));
        double rule2 = Math.Min(fuelEfficiency, safety);
        double rule3 = Math.Min(safety, cost);

        // Combine rules (numayis ucun sade ortalama)
        double decision = (rule1 + rule2 + rule3) / 3.0;

        return decision;
    }

    static void Main()
    {
        // Linquistik qiymetler ucun qeyri selis setler
        Console.Write("Enter fuel efficiency (0.0 to 1.0): ");
        double fuelEfficiency = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter safety (0.0 to 1.0): ");
        double safety = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter cost (0.0 to 1.0): ");
        double cost = Convert.ToDouble(Console.ReadLine());

        // Qeyri-selis qaydalar
        double decision = FuzzyLogic(fuelEfficiency, safety, cost);

        // Neticeni goster
        Console.WriteLine($"Fuzzy Decision: {decision}");
        Console.WriteLine("Selected car based on fuzzy logic:");

        if (decision > 0.6)
        {
            Console.WriteLine("Optimal choice: High fuel efficiency, high safety, and moderate cost.");
        }
        else if (decision > 0.3)
        {
            Console.WriteLine("Good choice: Moderate fuel efficiency, moderate safety, and low cost.");
        }
        else
        {
            Console.WriteLine("Consider other options: Low fuel efficiency, high safety, and low cost.");
        }
    }
}
