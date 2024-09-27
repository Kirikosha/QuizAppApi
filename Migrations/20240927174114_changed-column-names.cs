using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizAppApi.Migrations
{
    /// <inheritdoc />
    public partial class changedcolumnnames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_questions_QuestionId",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "FK_questions_quizes_QuizId",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "FK_results_quizes_QuizId",
                table: "results");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "users",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "results",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ResultPercentage",
                table: "results",
                newName: "result_percentage");

            migrationBuilder.RenameColumn(
                name: "QuizId",
                table: "results",
                newName: "quiz_id");

            migrationBuilder.RenameColumn(
                name: "Correct",
                table: "results",
                newName: "correct_answers");

            migrationBuilder.RenameIndex(
                name: "IX_results_QuizId",
                table: "results",
                newName: "IX_results_quiz_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "quizes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "quizes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "quizes",
                newName: "creation_time");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "questions",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "questions",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "questions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "QuizId",
                table: "questions",
                newName: "quiz_id");

            migrationBuilder.RenameIndex(
                name: "IX_questions_QuizId",
                table: "questions",
                newName: "IX_questions_quiz_id");

            migrationBuilder.RenameColumn(
                name: "Correct",
                table: "answers",
                newName: "correct");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "answers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "answers",
                newName: "question_id");

            migrationBuilder.RenameColumn(
                name: "AnswerText",
                table: "answers",
                newName: "answer_text");

            migrationBuilder.RenameIndex(
                name: "IX_answers_QuestionId",
                table: "answers",
                newName: "IX_answers_question_id");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_questions_question_id",
                table: "answers",
                column: "question_id",
                principalTable: "questions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_questions_quizes_quiz_id",
                table: "questions",
                column: "quiz_id",
                principalTable: "quizes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_quizes_quiz_id",
                table: "results",
                column: "quiz_id",
                principalTable: "quizes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_questions_question_id",
                table: "answers");

            migrationBuilder.DropForeignKey(
                name: "FK_questions_quizes_quiz_id",
                table: "questions");

            migrationBuilder.DropForeignKey(
                name: "FK_results_quizes_quiz_id",
                table: "results");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "users",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "results",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "result_percentage",
                table: "results",
                newName: "ResultPercentage");

            migrationBuilder.RenameColumn(
                name: "quiz_id",
                table: "results",
                newName: "QuizId");

            migrationBuilder.RenameColumn(
                name: "correct_answers",
                table: "results",
                newName: "Correct");

            migrationBuilder.RenameIndex(
                name: "IX_results_quiz_id",
                table: "results",
                newName: "IX_results_QuizId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "quizes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "quizes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "creation_time",
                table: "quizes",
                newName: "CreationTime");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "questions",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "questions",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "questions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "quiz_id",
                table: "questions",
                newName: "QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_questions_quiz_id",
                table: "questions",
                newName: "IX_questions_QuizId");

            migrationBuilder.RenameColumn(
                name: "correct",
                table: "answers",
                newName: "Correct");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "answers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "question_id",
                table: "answers",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "answer_text",
                table: "answers",
                newName: "AnswerText");

            migrationBuilder.RenameIndex(
                name: "IX_answers_question_id",
                table: "answers",
                newName: "IX_answers_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_questions_QuestionId",
                table: "answers",
                column: "QuestionId",
                principalTable: "questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_questions_quizes_QuizId",
                table: "questions",
                column: "QuizId",
                principalTable: "quizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_results_quizes_QuizId",
                table: "results",
                column: "QuizId",
                principalTable: "quizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
