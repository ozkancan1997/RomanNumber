using System;

namespace Roman
{
    class Program
    {
        public static void Main(string[] args){
            Console.WriteLine(Roman(1881));
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
      
      if(num>=900||num<400){
          d_count=0;
      }else{
          d_count=1;
      }
      num%=500;
      
      c_count=num/100;
      num%=100;
      
      if(num>=90||num<40){
          l_count=0;
      }else{
          l_count=1;
      }
      num%=50;
      
      x_count=num/10;
      num%=10;
      
      if(num>=9||num<4){
          v_count=0;
      }else{
          v_count=1;
      }
      num%=5;
      
      i_count=num;
      
      roman+=Multiply("M",m_count);
      if(d_count==1){
          if(c_count==4){
              roman+="CD";
          }else if(c_count==0){
              roman+="D";
          }else{
              roman+="D"+Multiply("C",c_count);
          }

      }else{
          if(c_count==4){
              roman+="CM";
          }else{
              roman+=Multiply("C",c_count);
          }
      }
      
      if(l_count==1){
          if(x_count==4){
              roman+="XL";
          }else if(x_count==0){
              roman+="L";
          }else{
              roman+="L"+Multiply("X",x_count);
          }

      }else{
          if(x_count==4){
              roman+="XC";
          }else{
              roman+=Multiply("X",x_count);
          }
      }
      
      if(v_count==1){
          if(i_count==4){
              roman+="IV";
          }else if(i_count==0){
              roman+="V";
          }else{
              roman+="V"+Multiply("I",i_count);
          }

      }else{
          if(i_count==4){
              roman+="IX";
          }else{
              roman+=Multiply("I",i_count);
          }
      }
      
      return roman;
  }
    }
    
}
