CREATE PROC	spGetRecipeCardView
	@Id int
AS
BEGIN
	SELECT Recipe.image, Recipe.Title, Recipe.Classification, Recipe.
	FROM Recipe
	WHERE Recipe.Id = @Id
END