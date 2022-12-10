



//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.



//DivideOrNot(42);
//static void DivideOrNot(int n)
//{
//	if (n%21==0)
//	{
//		Console.WriteLine("bolunur");
//	}
//	else
//	{
//		Console.WriteLine("bolunmur");
//	}
//}





//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.




//Sum(25, 42);
//static void Sum(int n,int k)
//{
//	int sum = 0;

//		if (n % 2 == 0 && k % 2 == 0) 
//	{
//		sum = n + k;
//		Console.WriteLine(sum);
//	}else
//	{
//		Console.WriteLine("Ededler cut deyil");
//	}
//}




//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.


//SingularSum(1, 10);

//static void SingularSum(int n , int m)
//{
//	int sum = 0;

//		for (int i = n; i < m; i++)
//	{
//		if (i%2==1)
//		{
//			sum = sum + i;
//		}
//	}
//	Console.WriteLine(sum);


//}




//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.




//int[] arr = { 1, 12, 9, 8, 21, 64, 25, 13 };
//SumArr(arr);



//static void SumArr(int[] arr)
//{
//    int sum = 0;
//	for (int i = 0; i < arr.Length; i++) 
//	{
//		if (arr[i] %2==1)
//		{
//			sum = sum + arr[i];	
//		}
//	}
//	Console.WriteLine(sum);
//}





//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.



//int[] arr = { 1, 12, 9, 8, 21, 64, 25, 13 };


//CountArr(arr);


//static void CountArr(int[] arr)
//{
//	int count = 0;
//	for (int i = 0; i < arr.Length; i++)
//	{
//		if (arr[i] % 2 == 0)
//		{
//			count++;
//		}
//	}
//	Console.WriteLine(count);
//}





//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.



//SingularCount(12, 48);

//static void SingularCount(int n, int m) 
//{
//	int count = 0;

//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//		{
//			count++;
//		}
//	}
//	Console.WriteLine(count);


//}


//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//PluralSum(12, 57);
//static void PluralSum(int n, int m)
//{
//	int sum = 0;

//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sum = sum + i;
//		}
//	}
//	Console.WriteLine(sum);


//}



//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.



//PluralCount(8, 35);

//static void PluralCount(int n,int m)
//{
//	int count = 0;

//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count++;
//		}
//	}
//	Console.WriteLine(count);


//}


//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.



//SimpleOrNot(37);



//static void SimpleOrNot(int n)
//{
//    int count = 0;
//	if (n < 0)
//	{
//		Console.WriteLine("eded menfidir");
//	}
//	else if (n == 0) 
//	{
//		Console.WriteLine("ne sadedir,nede murekkeb");
//	}
//	else
//	{
//		for (int i = 1; i <= n; i++) 
//		{
//			if (n%i==0)
//			{
//				count++;
//			}
//		}
//		if (count>2)
//		{
//			Console.WriteLine("murekkebdir");
//		}
//		else
//		{
//			Console.WriteLine("sadedir");
//		}
//	}
//}







//10)n ededinin faktorialini hesablamaq.


//NumsFactorial(11);


//static void NumsFactorial(long n)
//{
//    long result = 1;
//	for (int i = 1; i <= n; i++) 
//	{
//		result = result * i;
//	}
//	Console.WriteLine(result);

//}

