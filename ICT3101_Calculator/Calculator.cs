public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        // Check if the numbers contain 1 and 0 only
        if (IsBinary(num1) && IsBinary(num2))
        {
            // add num1 to num2 as string
            string result = num1.ToString() + num2.ToString();

            // convert string to binary
            int binary = Convert.ToInt32(result, 2);

            // convert binary to decimal
            return Convert.ToDouble(binary);
        }
        else
        {
            // Perform regular addition
            return num1 + num2;
        }
    }

    private bool IsBinary(double num)
    {
        string numString = num.ToString();
        foreach (char digit in numString)
        {
            if (digit != '0' && digit != '1')
            {
                return false;
            }
        }
        return true;
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {

        if (num1 == 0 && num2 == 0)
        {
            return 1;
        }
        if (num1 == 0)
        {
            return 0;
        }
        // handle divide by zero
        if (num2 == 0)
        {
            throw new ArgumentException("positive_infinity");
        }

        return (num1 / num2);
    }

    // factorial
    public double Factorial(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Cannot factorial negative number");
        }

        // decimal
        if (num1 % 1 != 0)
        {
            throw new ArgumentException("Cannot factorial decimal number");
        }

        // large number
        if (num1 > 60)
        {
            throw new ArgumentException("Cannot factorial number greater than 170");
        }

        if (num1 == 0)
        {
            return 1;
        }
        else
        {
            return Multiply(num1, Factorial(Subtract(num1, 1)));
        }
    }

    // area of triangle
    public double AreaOfTriangle(double num1, double num2)
    {
        if (num1 < 0 || num2 < 0)
        {
            throw new ArgumentException("Cannot calculate area of triangle with negative number");
        }
        return Divide(Multiply(num1, num2), 2);
    }

    // area of circle
    public double AreaOfCircle(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Cannot calculate area of circle with negative number");
        }
        return Multiply(Multiply(num1, num1), 3.142);
    }

    // unknown function a
    public double UnknownFunctionA(double a, double b)
    {
        if (a < b)
        {
            throw new ArgumentException("Cannot have num1 greater than num2");
        }

        //Permutation
        return Divide(Factorial(a), Factorial(Subtract(a, b)));
    }

    // unknown function b
    public double UnknownFunctionB(double a, double b)
    {
        if (a < b)
        {
            throw new ArgumentException("Cannot have num1 greater than num2");
        }

        // binomial coefficient
        return Divide(Factorial(a), Multiply(Factorial(b), Factorial(Subtract(a, b))));
    }

    // MTBF
    public double MTBF(double a, double b)
    {
        if (a < 0 || b < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return a + b;
    }

    // Availability
    public double Availability(double a, double b)
    {
        if (a < 0 || b < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        if (b < a)
        {
            throw new ArgumentException("MTTF cannot be lower than MTBF");
        }

        return Divide(a, b);
    }

    // Reliability
    // normal model
    public double CurrentFailureIntensity(double initial, double average, double total)
    {
        if (initial < 0 || average < 0 || total < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return Multiply(initial, Subtract(1, average / total));
    }

    public double AverageExpectedFailure(double time, double initial, double total)
    {
        if (time < 0 || initial < 0 || total < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return Math.Round(Multiply(total, Subtract(1, Math.Exp(Multiply(-1, Multiply(Divide(initial, total), time))))));
    }

    // logarithmic model
    public double CurrentFailureIntensityLog(double decay, double intensity, double failure)
    {
        if (decay < 0 || intensity < 0 || failure < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return Math.Round(Multiply(intensity, Math.Exp(Multiply(Multiply(-1, decay), failure))), 2);
    }

    public double AverageExpectedFailureLog(double decay, double intensity, double time)
    {
        if (time < 0 || decay < 0 || intensity < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return Math.Round(Multiply(Divide(1, decay), Math.Log(Add(Multiply((Multiply(decay, intensity)), time), 1))));
    }

    // Defect Density
    public double DefectDensity(double defects, double size)
    {
        if (defects < 0 || size < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return Divide(defects, size);
    }

    // New SSI
    public double NewSSI(double csi, double ssi, double deleted, double changed)
    {
        if (ssi < 0 || csi < 0 || deleted < 0 || changed < 0)
        {
            throw new ArgumentException("Cannot have negative number");
        }

        return Add(ssi, Subtract(csi, Add(deleted, changed)));
    }

    // generate magic number
    public double GenMagicNum(double input, IFileReader fileReader)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);
        //Dependency
        string[] magicStrings = fileReader.Read("C:\\Users\\micha\\OneDrive\\Desktop\\3101\\Lab1\\ICT3101_Calculator\\MagicNumbers.txt");
        // string[] magicStrings = getTheMagic.Read("..\\ICT3101_Calculator\\MagicNumbers.txt");
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        result = (result > 0) ? (2 * result) : (-2 * result);

        return result;
    }
}

