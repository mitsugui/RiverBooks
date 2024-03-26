using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RiverBooks.Books;

internal class BookConfiguration : IEntityTypeConfiguration<Book>
{
	internal static readonly Guid Book1Guid = new("1d666aa6-7be8-419a-bf0c-7c7df36779cc");
	internal static readonly Guid Book2Guid = new("3b1c8830-579e-41d2-ab91-4af7d443de9e");
	internal static readonly Guid Book3Guid = new("70dbe9fe-cb44-4be4-af0b-a4f98cda68da");

	public void Configure(EntityTypeBuilder<Book> builder)
	{
		builder.Property(p => p.Title)
			.HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
			.IsRequired();

		builder.Property(p => p.Author)
			.HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
			.IsRequired();

		builder.HasData(GetSampleBookData());
	}

	private IEnumerable<Book> GetSampleBookData()
	{
		var tolkien = "J.R.R. Tolkien";
		yield return new Book(Book1Guid, "The Fellowship of the Ring", tolkien, 10.99m);
		yield return new Book(Book2Guid, "The Two Towers", tolkien, 11.99m);
		yield return new Book(Book3Guid, "The Return of the King", tolkien, 12.99m);
	}
}