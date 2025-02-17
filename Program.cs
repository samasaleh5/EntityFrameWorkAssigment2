using EF02;
using EF02.Models;
using Microsoft.EntityFrameworkCore;
namespace EF02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIDbContext2 dbContext = new ITIDbContext2();
        }
    }
}
