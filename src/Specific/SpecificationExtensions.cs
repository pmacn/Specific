namespace Specific
{
    using System;
    using Krav;

    // ReSharper disable MethodNamesNotMeaningful

    /// <summary>
    /// Extensions for combining specifications using logical operations.
    /// </summary>
    public static class SpecificationExtensions
    {
        /// <summary>
        /// Creates a specification that demands that both <paramref name="left"/>
        /// and <paramref name="right"/> are satisfied.
        /// </summary>
        /// <param name="left">
        /// The left hand specification in the operation.
        /// </param>
        /// <param name="right">
        /// The right hand specification in the operation.
        /// </param>
        /// <typeparam name="T">
        /// The type of entity this specification checks.
        /// </typeparam>
        /// <returns>
        /// An <see cref="ISpecification{T}"/> representing the logical AND operation of the
        /// specifications  <paramref name="left"/> and <paramref name="right"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="left"/> or <paramref name="right"/> is null.
        /// </exception>
        public static ISpecification<T> And<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            return new AndSpecification<T>(left, right);
        }

        /// <summary>
        /// Creates a specification that demands that the <paramref name="source"/>
        /// specification is not satisfied.
        /// </summary>
        /// <param name="source">
        /// The source specification.
        /// </param>
        /// <typeparam name="T">
        /// The type of entity this specification checks.
        /// </typeparam>
        /// <returns>
        /// An <see cref="ISpecification{T}"/> representing the logical NOT operation of
        /// <paramref name="source"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="source"/> is null.
        /// </exception>
        public static ISpecification<T> Not<T>(this ISpecification<T> source)
        {
            RequireThat.NotNull(source, "source");

            return new NotSpecification<T>(source);
        }

        /// <summary>
        /// Creates a specification that demands that at least one of the
        /// <paramref name="left"/> and <paramref name="right"/> specifications are satisfied.
        /// </summary>
        /// <param name="left">
        /// The left hand side of the operation.
        /// </param>
        /// <param name="right">
        /// The right hand side of the operation
        /// </param>
        /// <typeparam name="T">
        /// The type of entity this specification checks.
        /// </typeparam>
        /// <returns>
        /// An <see cref="ISpecification{T}"/> representing the logical OR operation of the
        /// specifications <paramref name="left"/> and <paramref name="right"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="left"/> or <paramref name="right"/> is null.
        /// </exception>
        public static ISpecification<T> Or<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            return new OrSpecification<T>(left, right);
        }

        /// <summary>
        /// Creates a specification that demands that at one and only one of the
        /// <paramref name="left"/> and <paramref name="right"/> specifications are satisfied.
        /// </summary>
        /// <param name="left">
        /// The left hand side of the operation.
        /// </param>
        /// <param name="right">
        /// The right hand side of the operation
        /// </param>
        /// <typeparam name="T">
        /// The type of entity this specification checks.
        /// </typeparam>
        /// <returns>
        /// An <see cref="ISpecification{T}"/> representing the logical XOR operation of the
        /// specifications <paramref name="left"/> and <paramref name="right"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="left"/> or <paramref name="right"/> is null.
        /// </exception>
        public static ISpecification<T> Xor<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            RequireThat.NotNull(left, "left");
            RequireThat.NotNull(right, "right");

            return new XorSpecification<T>(left, right);
        }
    }
}
