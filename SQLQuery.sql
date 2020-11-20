USE Project

INSERT INTO dbo.Users (AccountId, IsActive, IsAdmin, IsBlocked) VALUES ('5', '1', '1', '1');

INSERT INTO dbo.Account (Username, Password, Email) VALUES ('Danone', 'comico', 'sdfsdfsdf@hotmail.com');

INSERT INTO dbo.Recipe(Title, UserId, Description, Duration, Difficulty, Isvalid, Classification) VALUES ('Rosbife', '2', 'sdfdsfgdsfgdfgsdfsd', '12:34:54.1237', 'NORMAL', 1, 'BOA');

INSERT INTO dbo.Ingredients(Name) VALUES ('Bife');

INSERT INTO dbo.Recipes_Ingredients(RecipeId, IngredientsId, IngredientQtn) VALUES ('2', '2', '10kg');

INSERT INTO dbo.Comments(UserId, RecipeId, Text, Date) Values ('2', '2', 'sdfsdfsdfsdfsdfsd', '1997-08-22');

INSERT INTO dbo.FavouriteRecipes(UserId, RecipesId) VALUES ('2', '2');

INSERT INTO dbo.Categories(Name) VALUES ('CARNES');

INSERT INTO dbo.OwnedRecipes(UserId, RecipesId) VALUES ('2', '2');

INSERT INTO dbo.Recipe_Categories(RecipeId, CategoriesId) VALUES ('2', '1');
