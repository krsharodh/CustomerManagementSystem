using System;
using Xunit;

namespace DeveloperPracticalTest.Tests
{
    public class CallNoteModelTests
    {
        [Fact]
        public void CallNoteModel_ShouldAddNewCallNote()
        {
            // Arrange
            string textExpected = "abc";

            // Act
            CallNoteModel callNoteActual = new CallNoteModel(1, "abc");


            // Assert
            Assert.Equal(textExpected, callNoteActual.Text);
        }

        [Fact]
        public void CallNoteModel_ShouldAddNewCallNoteWithParentCallNoteID()
        {
            // Arrange
            int parentCallNoteIDExpected = 1;

            // Act
            CallNoteModel callNoteActual = new CallNoteModel(1, 1, "abc");


            // Assert
            Assert.Equal(parentCallNoteIDExpected, callNoteActual.ParentCallNoteId);
        }
    }
        
}
