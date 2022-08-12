using CompoundInterestCalculatorWebAPI.BalanceCalculations.CalculateBalancewithCompoundInterest;
using CompoundInterestCalculatorWebAPI.Models;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CompoundInterestCalculatorWebAPI.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class CompoundInterestController : ControllerBase
    {
        // All the action methods or processes associated with CompoundInterest class will be conducted within this controller.

        public CompoundInterestController() /* The empty construction method was generated.
                                            It was created as a result of further requirements such as dbContext. */
        {

        }

        [HttpGet]
        public IActionResult CalculateTotalBalancewithCompoundInterest([FromQuery] CompoundInterest compoundInterest)

        // This is the action method that will handle all the calculations associated with the compound interest method.
        // "compoundInterest" instance was generated from "CompoundInterest" class in order to get parameters of the problem from query.
        // To make the code more readible, Related calculations are done within the "CompoundInterestCommand". 
        {
            CompoundInterestCommand command = new CompoundInterestCommand(); // Created instance of "CompoundInterestCommand" class.

            try
            {
                command.Model = compoundInterest; /* Parameters taken from query by "compoundInterest" instance are transferred
                                               to the "Model", which is a property of the "CompoundInterestCommand" class. */
                
                CompundInterestCommandValidator validator = new CompundInterestCommandValidator();
                validator.ValidateAndThrow(command);
                var result = command.Calculate(); //Mathematical calculations were carried out.
                return Ok(result); //The result is returned with an http success response.
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }  
        }

    }
}
