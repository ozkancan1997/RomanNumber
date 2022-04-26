using System;

namespace Roman
{
    class Program
    {
        public static void Main(string[] args){
            Console.WriteLine(Roman(2022));
        }
        public static string Multiply(string input, int times)
{
    string temp="";
     for(int i=0;i<times;i++){
         temp+=input;
     }
     return temp;
}
  
  public static string Roman(int num){
      string roman="";
      int m_count,d_count,c_count,l_count,x_count,v_count,i_count;
      m_count=num/1000;
      if(m_count>3){
          return "Too Big";
      }else{
          num%=1000;
      }
      
      d_count=num/500;
      num%=500;
      
      c_count=num/100;
      num%=100;
      
      l_count=num/50;
      num%=50;
      
      x_count=num/10;
      num%=10;
      
      v_count=num/5;
      num%=5;
      
      i_count=num;
      
      roman+=Multiply("M",m_count);
      roman+=Multiply("D",d_count);
      if(c_count>3){
          if(d_count==0){
              roman+=Multiply("C",(5-c_count))+"D";
          }else{
              roman+=Multiply("C",(5-c_count))+"M";
          }
      }else{
          roman+=Multiply("C",c_count);
      }
      
      roman+=Multiply("L",l_count);
      
      if(x_count>3){
          if(l_count==0){
              roman+=Multiply("X",(5-x_count))+"L";
          }else{
              roman+=Multiply("X",(5-x_count))+"C";
          }
      }else{
          roman+=Multiply("X",x_count);
      }
      
      roman+=Multiply("V",v_count);
      
      if(i_count>3){
          if(v_count==0){
              roman+=Multiply("I",(5-i_count))+"V";
          }else{
              roman+=Multiply("I",(5-i_count))+"X";
          }
      }else{
          roman+=Multiply("I",i_count);
      }
      
      return roman;
  }
    }
    
}
