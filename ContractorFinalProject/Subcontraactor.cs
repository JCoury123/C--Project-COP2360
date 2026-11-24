using System;
 
// Derived class: Subcontractor IS-A Contractor.
// It inherits the name, number, and start date from Contractor
// and adds the shift and hourly pay rate.
public class Subcontractor : Contractor
{
    // Shift values: 1 = day shift, 2 = night shift.
    public const int DayShift = 1;
    public const int NightShift = 2;
 
    // The night shift differential is 3%.
    private const double NightDifferential = 0.03;
 
    private int shift;
    private double hourlyPayRate;
 
    // Default constructor.
    // Calls the Contractor default constructor first.
    public Subcontractor() : base()
    {
        shift = DayShift;
        hourlyPayRate = 0.0;
    }
 
    // Constructor that accepts all of the information.
    // The inherited values are passed up to the Contractor constructor.
    public Subcontractor(string name, string number, DateTime startDate,
                         int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        SetShift(shift);               // uses validation
        SetHourlyPayRate(hourlyPayRate); // uses validation
    }
 
    // Getter for the shift.
    public int GetShift()
    {
        return shift;
    }
 
    // Setter for the shift. Only 1 (day) or 2 (night) is allowed.
    public void SetShift(int newShift)
    {
        if (newShift != DayShift && newShift != NightShift)
        {
            throw new ArgumentException("Shift must be 1 (day) or 2 (night).");
        }
        shift = newShift;
    }
 
    // Getter for the hourly pay rate.
    public double GetHourlyPayRate()
    {
        return hourlyPayRate;
    }
 
    // Setter for the hourly pay rate. Negative rates are not allowed.
    public void SetHourlyPayRate(double newRate)
    {
        if (newRate < 0)
        {
            throw new ArgumentException("Hourly pay rate cannot be negative.");
        }
        hourlyPayRate = newRate;
    }
 
    // Calculates the pay for the hours worked and returns a float.
    // Night shift employees receive a 3% shift differential.
    public float CalculatePay(double hoursWorked)
    {
        if (hoursWorked < 0)
        {
            throw new ArgumentException("Hours worked cannot be negative.");
        }
 
        double pay = hoursWorked * hourlyPayRate;
 
        if (shift == NightShift)
        {
            pay = pay * (1.0 + NightDifferential);
        }
 
        return (float)pay;
    }
}
 
