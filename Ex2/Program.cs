// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFICENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double [] lineData1 = InputLineData(LINE1);
double [] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords (lineData1, lineData2);
    System.Console.WriteLine($"Точка пересечения уравнений y = {lineData1 [COEFICENT] } *x+ {lineData1[CONSTANT] } и y = {lineData2[COEFICENT] } *x+ {lineData2[CONSTANT]} ");
        System.Console.WriteLine($"имеет координаты {coord [X_COORD]}, {coord [Y_COORD]}");
}

double Prompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[COEFICENT] = Prompt($"Введите коэффицент для {numberOfLine} прямой: ");
    lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой: ");
    return lineData;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_COORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFICENT] - lineData1[COEFICENT]);
    coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFICENT] == lineData2[COEFICENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            System.Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("Прямые паралельны");
            return false;
        }
    }
    return true;
}
