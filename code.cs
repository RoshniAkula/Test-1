using System;
public class Test
{
	public static void Main()
	{
	string input1=Console.ReadLine();
      int input2=Convert.ToInt32(Console.ReadLine());
      String expand="";
      String str="";
      int x=0;
      for(int i=0;i<input1.Length;)
        {
            str="";
            x=0; 
            while(i<input1.Length && input1[i]>='a' && input1[i]<='z')
            {
                str+=input1[i];
                i++;
            }
            while(i<input1.Length && input1[i] >='1' && input1[i]<='9')
            {
                x=x*10+input1[i]-'0';
                i++;
            }
            for (int j=1;j<=x;j++){
                expand+= str;
            }
        }
        if(x==0)
            expand+= str;
        if(input2>expand.Length)
            Console.WriteLine("-1");
        else Console.WriteLine(expand[input2-1]);
	}
}
