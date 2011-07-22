using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Interfaces
{
    /// <summary>
    /// The problem interface. Define what our individual 
    /// problems should look like
    /// </summary>
    interface IProblem
    {
        /// <summary>
        /// The answer to the problem.
        /// </summary>
        /// <returns>A decimal representation of our answer (could also be an integer)</returns>
        Decimal Answer();

        /// <summary>
        /// The problem number we're on
        /// </summary>
        /// <returns>The problem number.</returns>
        int ProblemNumber();
    }
}
