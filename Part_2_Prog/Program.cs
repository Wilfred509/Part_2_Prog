using System;

using System.Collections.Generic;



namespace RecipeManager

{

    class Ingredient

    {

        public string Name { get; set; }

        public double Quantity { get; set; }

        public string Unit { get; set; }

        public int Calories { get; set; }

        public string FoodGroup { get; set; }

    }



    class Step

    {

        public string Description { get; set; }

    }



    class Recipe

    {

        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Step> Steps { get; set; }

        public int TotalCalories { get; private set; }



        public Recipe(string name, List<Ingredient> ingredients, List<Step> steps)

        {

            Name = name;

            Ingredients = ingredients;

            Steps = steps;

            TotalCalories = CalculateTotalCalories();

        }



        private int CalculateTotalCalories()

        {

            int totalCalories = 0;

            foreach (Ingredient ingredient in Ingredients)

            {

                totalCalories += ingredient.Calories;

            }

            return totalCalories;

        }

    }



    class RecipeManager

    {

        private List<Recipe> recipes;



        public RecipeManager()

        {

            recipes = new List<Recipe>();

        }



        public void AddRecipe(Recipe recipe)

        {

            recipes.Add(recipe);

        }



        public void RemoveRecipe(Recipe recipe)

        {

            recipes.Remove(recipe);

        }



        public List<Recipe> GetRecipeList()

        {

            return recipes;

        }



        public Recipe GetRecipeByName(string name)

        {

            foreach (Recipe recipe in recipes)

            {

                if (recipe.Name == name)

                {

                    return recipe;

                }

            }

            return null;

        }

    }



    class UI

    {

        private RecipeManager recipeManager;



        public UI()

        {

            recipeManager = new RecipeManager();

        }



        public void Run()

        {

            bool exit = false;

            while (!exit)

            {

                Console.WriteLine("Welcome to Recipe Manager!");

                Console.WriteLine("Please choose an option:");

                Console.WriteLine("1. Add a recipe");

                Console.WriteLine("2. Remove a recipe");

                Console.WriteLine("3. Display recipe list");

                Console.WriteLine("4. Display recipe details");

                Console.WriteLine("5. Scale recipe");

                Console.WriteLine("6. Reset recipe quantities");

                Console.WriteLine("7. Clear all data");

                Console.WriteLine("8. Exit");



                int choice int.Parse(Console.ReadLine());



                switch (choice)

                {

                    case 1:

                        AddRecipe();

                        break;

                    case 2:

                        RemoveRecipe();

                        break;

                    case 3:

                        DisplayRecipeList();

                        break;

                    case 4:

                        DisplayRecipeDetails();

                        break;

                    case 5:

                        ScaleRecipe();

                        break;

                    case 6:

                        ResetRecipeQuantities();

                        break;

                    case 7:

                        ClearAllData();

                        break;

                    case 8:

                        exit = true;

                        break;

                    default:

                        Console.WriteLine("Invalid choice!");

                        break;

                }



                Console.WriteLine();

            }

        }
    }
}

