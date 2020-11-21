USE Project

INSERT INTO dbo.Users (Username, Password, Email, IsActive, IsBlocked) VALUES ('Danoninho22', 'sdfsdfsdf', 'kiyuohmjbgjghj', '1', '0');

INSERT INTO dbo.Recipe(Title, UserId, Description, Duration, Difficulty, IsValid, Classification) VALUES ('Rosbife', '1', 'sdfdsfgdsfgdfgsdfsd', '12:34:54.1237', 'NORMAL', 1, 'BOA');

INSERT INTO dbo.Ingredients(Name) VALUES ('Bife');

INSERT INTO dbo.Recipes_Ingredients(RecipeId, IngredientsId, IngredientQtn) VALUES ('6', '1002', '10kg');

INSERT INTO dbo.Comments(UserId, RecipeId, Text, Date) Values ('1', '6', 'sdfsdfsdfsdfsdfsd', '1997-08-22');

INSERT INTO dbo.FavouriteRecipes(UserId, RecipesId) VALUES ('1', '6');

INSERT INTO dbo.Categories(Name) VALUES ('CARNES');

INSERT INTO dbo.OwnedRecipes(UserId, RecipesId) VALUES ('1', '6');

INSERT INTO dbo.Recipe_Categories(RecipeId, CategoriesId) VALUES ('6', '4');

EXEC spGetAll;
EXEC spGetUserById @id = 1;
EXEC spAddUser @Username = 'culhao45', @Password = 'sportingmerd4', @Email = 'sdfsdfsdf@sdfsdfs.ertrtey';
