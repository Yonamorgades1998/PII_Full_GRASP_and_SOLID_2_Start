//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /// <summary>
        /// Aplicando SRP PODEMOS DETECTAR QUE LA RESPONSABILID DE IMPRIMIR NO DEBERIA PERTENECER A LA RECETA
        /// CREANDO UNA CLASE CUYA RESPONSABILIDAD SEA IMPRIMIR PODEMOS MODIFICAR EL METODO Y DESTINO DE LA IMPRESION SIN NECESIDAD DE MODIFICAR EL RESTO DE LAS CLASES
        /// </summary>
        /// <param name="recipe"></param>
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }

    }
}