/******************************************************************************

                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/
interface arithmetic_op{
    void welcome_message();
    void add();
    void subtract();
}
class arith implements arithmetic_op{
    int a,b;
    arith(int x, int y){
        a=x;
        b=y;
    }
    public void welcome_message(){
        System.out.println("Welcome to this application");
    }
    public int add(a,b){
        return a+b;
    }
    public int subtract(){
        return a-b;
    }
} 
public class Main
{
	public static void main(String[] args) {
		arith code = new arith();
		
	}
}
