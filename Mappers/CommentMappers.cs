using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMappers
    {
        public static CommentDto ToCommentDto(this Comment comment)
        {
            return new CommentDto
            {
                Id = comment.Id,
                Title = comment.Title,
                Content = comment.Content,
                CreateOn = comment.CreateOn,
                StockId = comment.StockId,
            };
        }

        public static Comment ToCommentCreateDto(this CreateCommentRequestDto comment, int stockId)
        {
            return new Comment
            {
                Title = comment.Title,
                Content = comment.Content,
                StockId = stockId,
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto comment)
        {
            return new Comment
            {
                Title = comment.Title,
                Content = comment.Content,
            };
        }

    }
}
