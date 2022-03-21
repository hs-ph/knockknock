
namespace KnockKnock.Web.Services
{
    public class TriangleService : ITriangleService
    {

        public string GetTriangleType(int a, int b, int c)
        {
        
            if (!IsValidTriangle(a, b, c))
                return "error";
            
            if (IsEquilateral(a, b, c))
                return "Equilateral";

            return IsScalene(a, b, c)
                ? "Scalene"
                : "Isosceles";
        }

        private bool IsValidTriangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return false;

            return ((a + b) > c && (a + c) > b && (b + c) > a);
        }

        private bool IsEquilateral(int a, int b, int c)
        {
            return a == b && b == c;
        }

        private bool IsScalene(int a, int b, int c)
        {
            return a != b
                   && a != c
                   && b != c;
        }
    }
}