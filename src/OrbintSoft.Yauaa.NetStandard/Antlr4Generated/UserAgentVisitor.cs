//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Antlr4Source\UserAgent.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OrbintSoft.Yauaa.Antlr4Source {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="UserAgentParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IUserAgentVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.userAgent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUserAgent([NotNull] UserAgentParser.UserAgentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.rootElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRootElements([NotNull] UserAgentParser.RootElementsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.rootText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRootText([NotNull] UserAgentParser.RootTextContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.product"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProduct([NotNull] UserAgentParser.ProductContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.commentProduct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommentProduct([NotNull] UserAgentParser.CommentProductContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productVersionWords"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductVersionWords([NotNull] UserAgentParser.ProductVersionWordsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductName([NotNull] UserAgentParser.ProductNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameWords"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameWords([NotNull] UserAgentParser.ProductNameWordsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productVersion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductVersion([NotNull] UserAgentParser.ProductVersionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productVersionWithCommas"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductVersionWithCommas([NotNull] UserAgentParser.ProductVersionWithCommasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productVersionSingleWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductVersionSingleWord([NotNull] UserAgentParser.ProductVersionSingleWordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.singleVersion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleVersion([NotNull] UserAgentParser.SingleVersionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.singleVersionWithCommas"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSingleVersionWithCommas([NotNull] UserAgentParser.SingleVersionWithCommasContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameVersion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameVersion([NotNull] UserAgentParser.ProductNameVersionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameEmail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameEmail([NotNull] UserAgentParser.ProductNameEmailContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameUrl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameUrl([NotNull] UserAgentParser.ProductNameUrlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameUuid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameUuid([NotNull] UserAgentParser.ProductNameUuidContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.uuId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUuId([NotNull] UserAgentParser.UuIdContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.emailAddress"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmailAddress([NotNull] UserAgentParser.EmailAddressContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.siteUrl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSiteUrl([NotNull] UserAgentParser.SiteUrlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.base64"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBase64([NotNull] UserAgentParser.Base64Context context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.commentSeparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommentSeparator([NotNull] UserAgentParser.CommentSeparatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.commentBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommentBlock([NotNull] UserAgentParser.CommentBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.commentEntry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCommentEntry([NotNull] UserAgentParser.CommentEntryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameKeyValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameKeyValue([NotNull] UserAgentParser.ProductNameKeyValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.productNameNoVersion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProductNameNoVersion([NotNull] UserAgentParser.ProductNameNoVersionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.keyValueProductVersionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyValueProductVersionName([NotNull] UserAgentParser.KeyValueProductVersionNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.keyValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyValue([NotNull] UserAgentParser.KeyValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.keyWithoutValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyWithoutValue([NotNull] UserAgentParser.KeyWithoutValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.keyValueVersionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyValueVersionName([NotNull] UserAgentParser.KeyValueVersionNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.keyName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitKeyName([NotNull] UserAgentParser.KeyNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.emptyWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyWord([NotNull] UserAgentParser.EmptyWordContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.multipleWords"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultipleWords([NotNull] UserAgentParser.MultipleWordsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="UserAgentParser.versionWords"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVersionWords([NotNull] UserAgentParser.VersionWordsContext context);
}
} // namespace OrbintSoft.Yauaa.Antlr4Source
