USE CarlosFerreira_Project

INSERT INTO dbo.Users (Username, Password, Email, IsActive, IsBlocked) VALUES ('Danoninho22', 'sdfsdfsdf', 'kiyuohmjbgjghj', '1', '0');

INSERT INTO dbo.Recipe(Title, UserId, Description, Duration, Difficulty, IsValid, Classification ) VALUES ('polvo', '1', 'sdfdsfgdsfgdfsgdfçlkdsfhgfkjsxdzhgfkjsdfhgsdkfhsgflisdhfglsj.dhfvgls.dhfgsldjhfgosludhfglsjdhsdfjksDHFKJLHGL ÇIADFGDAHKBG ÇDEIARDHJGFH BLÇSA.DFHJGBSLÇ.DHFGBAÇ.LDHJFRÇbghjldbgjkdbgçkdjfhgçidujghçidfjgbçdfkxbgvmnxcbgçdiejrfghb+erºojughd+foºjghbdfjgbncxçvkkjbvçd-fjghedurghodifugyidujghy35986yte9rgthdçifjghbçdjfghfgslidhvbvxcljhvgwouiyertgjlhsdfbvgsdfsd', '12:34:54.1237', '0', 0, '0');

INSERT INTO dbo.Ingredients(Name, IsValid) VALUES ('Atum', '1');

INSERT INTO dbo.Recipes_Ingredients(RecipeId, IngredientsId, IngredientQtn) VALUES ('6', '23', '10kg');

INSERT INTO dbo.Comments(UserId, RecipeId, Text, Date) Values ('1008', '6', 'sdfsdfsdfsdfsdfsd', '1997-08-22');

INSERT INTO dbo.FavouriteRecipes(UserId, RecipesId) VALUES ('1008', '6');

INSERT INTO dbo.Categories(Name) VALUES ('MASSAS');

INSERT INTO dbo.OwnedRecipes(UserId, RecipesId) VALUES ('1008', '6');

INSERT INTO dbo.Recipe_Categories(RecipeId, CategoriesId) VALUES ('6', '1009');

--User
EXEC spGetAll;
EXEC spGetUserById;
EXEC spAddUser;
EXEC spUpdateUser ;
EXEC spUpdateUserClient;
EXEC spDeleteUser;

EXEC spBlockedUsers;
EXEC spBlockUnblockUser;
EXEC spFavouriteRecipes;
EXEC spOwnedRecipes;

--Ingrediente
EXEC spGetAllIngredients;
EXEC spGetIngredientByID;
EXEC spAddIngredient;
EXEC spUpdateIngredient;
EXEC spDeleteIngredient;

EXEC spInvalidIngredients;

--Categories
EXEC spGetAllCategories;
EXEC spGetCategoryByID;
EXEC spAddCategory;
EXEC spUpdateCategory;
EXEC spDeleteCategory;

--Comments
EXEC spGetAllComments;
EXEC spGetCommentByID;
EXEC spAddComment;
EXEC spUpdateComment;
EXEC spDeleteComment;

EXEC spUserComments;

-- Recipes
