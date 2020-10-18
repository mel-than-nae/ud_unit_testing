using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgumentIsNull_ThrowArgumentNullException()
        {
            var stack = new Fundamentals.Stack<string>();
            
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArgument_AddTheObjectToTheStack()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            Assert.That(stack.Count, Is.EqualTo(1));
        }
        
        
        [Test]
        public void Count_EmptyStack_ShouldReturnZero()
        {
            var stack = new Fundamentals.Stack<string>();
            Assert.That(stack.Count, Is.EqualTo(0));
        }
        
        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();
            Assert.That(() =>stack.Pop(), Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnsObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result = stack.Pop();
            Assert.That(result, Is.EqualTo("b"));
        }
        
        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            var result = stack.Pop();
            Assert.That(stack.Count, Is.EqualTo(1));
        }

     
        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Fundamentals.Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObject_ReturnObjectOnTopOfTheStack()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("abc");
            Assert.That(stack.Peek(), Is.EqualTo("abc"));
        }

        [Test]
        public void Peek_StackWithObject_DoesNotRemoveTheObjectAtTheTopOfTheStack()
        {
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            var dummy = stack.Peek();
            Assert.That(stack.Count, Is.EqualTo(1));
            
        }
    }
}