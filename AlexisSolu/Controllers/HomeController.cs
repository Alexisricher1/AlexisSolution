using System.Net;
using Microsoft.AspNetCore.Mvc;
using AlexisSolu.Models;

namespace AlexisSolu.Controllers
{
    public class HomeController : Controller
    {
        private const MatrixModel.MatrixModelBase DEFAULT_MATRIX_BASE = MatrixModel.MatrixModelBase.Decimal;

        public const int DEFAULT_MATRIX_VALUE = 10;
        public const int MIN_MATRIX_VALUE = 3;
        public const int MAX_MATRIX_VALUE = 15;

        public IActionResult Index()
        {
            return View(new MatrixModel(DEFAULT_MATRIX_VALUE, DEFAULT_MATRIX_BASE));
        }

        public IActionResult GenerateNewMatrix(int pSize, MatrixModel.MatrixModelBase pBase)
        {
            var newMatrix = new MatrixModel(pSize, pBase);

            // Should probably be using fluent validation
            if (!IsValidMatrixSize(newMatrix))
            {
                return BadRequest($"Matrix size parameter must be between {MIN_MATRIX_VALUE} and {MAX_MATRIX_VALUE}.");
            }

            return View("Index", newMatrix);
        }

        private bool IsValidMatrixSize(MatrixModel pMatrix)
        {
            return pMatrix.Size >= MIN_MATRIX_VALUE && pMatrix.Size <= MAX_MATRIX_VALUE;
        }
    }
}

