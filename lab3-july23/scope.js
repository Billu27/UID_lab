
// use of let and var

var  temp=0; // 'temp' is global value can be used in all funtion
let t=7;  // 't' is global value can be used in all funtion

function calcu(){
var cel=91; //'cel' can be used only in calcu funtion
let far=9; // 'far' can be used in the function
   if(cel==91)
      {
         let a=5;   // scope of 'a' is block scope i.e.  no reference outside
      }
else {
         var b=6;  // scope of 'b'  is function block
     }
	 //value of 'a' is not accessible
	 //value of 'b' is  accessible
	 
	 }

function calcu123(){
 var i=6;
  }

