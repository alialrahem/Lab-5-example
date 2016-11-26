
namespace ConsoleApplication21
{
    class TableBoard
    {
        public int cellsize;
        public string[][] Grid;



        public TableBoard(int cellsize)
        {

            this.cellsize = cellsize;
            this.Grid = new string[cellsize][];
            {
                for (int i = 0; i < cellsize; i++)
                {

                    this.Grid[i] = new string[cellsize];
                }
            }

        }
        public void Fillarry()
        {
            for (int i = 0; i < 8; i++)
            {

                

                
                for (int j = 0; j < 8; j++)
                {


                   this.Grid[i][j]=(" X");
                  


                   if (i > 3)
                   {
                       this.Grid[i][j] = "x";
                   }
                   else
                   {

                       this.Grid[0][5] = "x";
                   }
                    if (j<2)
                    {

                        this.Grid[i][j] = "x";
                    }
                    else
                   {
                       this.Grid[0][7] = "x";
                   }
                }
            }   
       
        }
    

    






        public void print()
        {

            foreach (string[] row in Grid)
            {
                System.Console.WriteLine();
                foreach (string stringValue in row)
                {
                    System.Console.WriteLine(stringValue);
                }

            }

        }

    }

}     
    

