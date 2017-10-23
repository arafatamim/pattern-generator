using System;

namespace PatternGenerator
{
	class Program
	{
		public static void Main(string[] args)
		{
		mainprog:
			Console.WriteLine("Star Pattern Generator by Tamim Arafat\n===================\n");	
			Console.Write("Select type:\n 1: Left Pyramid\n 2: Inverted Left Pyramid\n 3: Right Pyramid\n 4: Inverted Right Pyramid\n 5: Diamond Pattern\n==> ");
			char type=Console.ReadKey().KeyChar;	//takes a single char value
			Console.WriteLine();
			switch (type){	
					case '1': LeftPyramid();
					break;
					case '2': InvertedLeftPyramid();
					break;
					case '3': RightPyramid();
					break;
					case '4': InvertedRightPyramid();
					break;
					case '5': Diamond();
					break;
					default: {
                        Console.Clear();
                        goto mainprog;
                    }
			}
			
		}
		
		//Start of different pyramid methods:
		
		static void LeftPyramid(){
		lpstart:
			Console.Write("\nLeft Pyramid\n==================\nEnter no. of rows to be generated: ");
			try{
				int rows=int.Parse(Console.ReadLine());
				Console.WriteLine();
				for (int row = 1; row <= rows; ++row)
        		{
            		for (int col = 1; col <= row; ++col)
            		{
               			Console.Write("*");
            		}
 
           		Console.WriteLine();
        		}
				Console.WriteLine("Do you want to restart? (y/N): "); //Code for y/n restart
				char input=Console.ReadKey().KeyChar;
				switch (input) {
						case 'y':{ Console.Clear(); Main(null);}
						break;
						case 'Y':{ Console.Clear(); Main(null);}
						break;
						default: Environment.Exit(0);
						break;
				}
			}
			catch (Exception e){
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(e.Message + " Try again.");
				Console.ResetColor();
				goto lpstart;
			}
		}
		
		static void InvertedLeftPyramid(){
		ilpstart:
			Console.Write("\nInverted Left Pyramid\n==================\nEnter no. of rows to be generated: ");
			try{
				int rows = int.Parse(Console.ReadLine());
				Console.WriteLine();
				for (int row = rows; row >= 1; --row)
        		{
            		for (int col = 1; col <= row; ++col)
            		{
               			Console.Write("*");
            		}
            	Console.WriteLine();
       			}
				Console.WriteLine("Do you want to restart? (y/N): ");
				char input=Console.ReadKey().KeyChar;
				switch (input) {
						case 'y':{ Console.Clear(); Main(null);}
						break;
						case 'Y':{ Console.Clear(); Main(null);}
						break;
						default: Environment.Exit(0);
						break;
				}
			}
			catch (Exception e){
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine(e.Message+" Try again.");
				Console.ResetColor();
				goto ilpstart;
			}
		}
		
		static void RightPyramid(){
			rpstart:
			Console.Write("\nRight Pyramid\n==================\nEnter no. of rows to be generated: ");
			try{
				int rows=int.Parse(Console.ReadLine());
				Console.WriteLine();
				int i, j, k;
        		for (i = 1; i <= rows; i++)
        		{
            		for (j = 1; j <= rows - i; j++)
            		{
                		Console.Write(" ");
            		}
            		for (k = 1; k <= i; k++)
            		{
            	    	Console.Write("*");
            		}
            	Console.WriteLine();
        		}
        		Console.WriteLine("Do you want to restart? (y/N): ");
        		char input=Console.ReadKey().KeyChar;
				switch (input) {
						case 'y':{ Console.Clear(); Main(null);}
						break;
						case 'Y':{ Console.Clear(); Main(null);}
						break;
						default: Environment.Exit(0);
						break;
				}
        		
			}
			catch (Exception e){
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine(e.Message+" Try again.");
				Console.ResetColor();
				goto rpstart;
			}
		}
		
		static void InvertedRightPyramid(){
			irpstart:
			Console.Write("\nInverted Right Pyramid\n==================\nEnter no. of rows to be generated: ");
			try{
				int rows=int.Parse(Console.ReadLine());
				Console.WriteLine();
				int i, j, k;
        		for (i = rows; i >= 1; i--)
        		{
            		for (j = 1; j <= rows - i; j++)
            		{
                		Console.Write(" ");
            		}
            		for (k = 1; k <= i; k++)
            		{
            	    	Console.Write("*");
            		}
            	Console.WriteLine();
        		}
        		Console.WriteLine("Do you want to restart? (y/N): ");
        		char input=Console.ReadKey().KeyChar;
				switch (input) {
						case 'y':{ Console.Clear(); Main(null);}
						break;
						case 'Y':{ Console.Clear(); Main(null);}
						break;
						default: Environment.Exit(0);
						break;
				}
			}
			catch (Exception e){
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine(e.Message+" Try again.");
				Console.ResetColor();
				goto irpstart;
			}
		}
		
		static void Diamond(){
		dstart:
			Console.Write("\nDiamond Pattern\n==================\nEnter no. of rows to be generated: ");
			try{
				int rows=int.Parse(Console.ReadLine());
				Console.WriteLine();
				int i, k, count = 1;
        		count = rows - 1;
        		for (k = 1; k <= rows; k++){
            		for (i = 1; i <= count; i++)
                		Console.Write(" ");
            		count--;
            		for (i = 1; i <= 2 * k - 1; i++)
               			Console.Write("*");
            		Console.WriteLine();
       			}
        	count = 1;
        	for (k = 1; k <= rows - 1; k++){
            	for (i = 1; i <= count; i++)
                	Console.Write(" ");
            	count++;
            	for (i = 1; i <= 2 * (rows - k) - 1; i++)
                	Console.Write("*");
            	Console.WriteLine();
        	}
        	Console.WriteLine("Do you want to restart? (y/N): ");
        	char input=Console.ReadKey().KeyChar;
				switch (input) {
						case 'y':{ Console.Clear(); Main(null);}
						break;
						case 'Y':{ Console.Clear(); Main(null);}
						break;
						default: Environment.Exit(0);
						break;
				}
        	}
			catch (Exception e){
				Console.ForegroundColor=ConsoleColor.Red;
				Console.WriteLine(e.Message+" Try again.");
				Console.ResetColor();
				goto dstart;}
		}
	}
	
}
	