/*
Carlos Felipe
10/25/22
Greater Than or Less Than - Endpoint
CODE: This code takes in a user's input in the url and then displays whether the first number inputted is less than, greater than, or equal to the second number
Peer Review by Griffin Parker: This program works perfectly and does everything it needs to. The code is organized and everything looks good. Great work! 
*/
using Microsoft.AspNetCore.Mvc;

namespace FelipeCGreaterThanOrLessThanEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EvaluateController : ControllerBase
{
    public string Instructions(){
        return "Type in https://localhost:9000/evaluate/values/first number/second number";
    }

    [HttpGet]
    [Route("Values/{numOne}/{numTwo}")]
    public string Values(string numOne, string numTwo){
        int intOne = Convert.ToInt32(numOne);
        int intTwo = Convert.ToInt32(numTwo);
        if(intOne < intTwo){
            return $"{numOne} is less than {numTwo}";
        }
        if(intOne > intTwo){
            return $"{numOne} is greater than {numTwo}";
        }
        else{
            return $"{numOne} is equal to {numTwo}";
        }
    }
}
