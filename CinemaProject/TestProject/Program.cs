using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDAO dao = new MovieDAO();
            DateTime date = DateTime.Now.AddDays(-1);
            List<MovieDTO> movies = dao.GetMovieByDay(date);
            foreach(MovieDTO mv in movies)
            {
                Console.WriteLine($"{mv.MovieName}");
            }
            Console.ReadLine();
        }
    }
    }
