using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    { 
        _article = new Article(); 
    }


    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] input = 
            { 
                "Article Content Author",
                "Article2 Content2 Author2",
                "Article3 Content3 Author3",
            } ;

        // Act
        Article result = _article.AddArticles(input);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        string[] input =
            {
                "CArticle Content Author",
                "Article2 Content2 Author2",
                "BArticle3 Content3 Author3",
            };

        string sortCriteria = "title";

        Article result = _article.AddArticles(input);

        string output = _article.GetArticleList(result, sortCriteria);
        string expected = $"Article2 - Content2: Author2{Environment.NewLine}" +
                            $"BArticle3 - Content3: Author3{Environment.NewLine}CArticle - Content: Author";

        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        string[] input =
    {
                "CArticle Content Author",
                "Article2 Content2 Author2",
                "BArticle3 Content3 Author3",
            };

        string sortCriteria = "home";

        Article result = _article.AddArticles(input);

        string output = _article.GetArticleList(result, sortCriteria);
        string expected = string.Empty;

        Assert.That(output, Is.EqualTo(expected));

    }
}
