﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Blazorise.Docs.Compiler.ApiDocsGenerator.Dtos;

public record ComponentInfo( INamedTypeSymbol Type, IEnumerable<IPropertySymbol> Properties, IEnumerable<IMethodSymbol> PublicMethods, IEnumerable<INamedTypeSymbol> InheritsFromChain, string Category, string Subcategory, string SearchUrl, string Summary )
{
    public INamedTypeSymbol Type { get; } = Type;
    public IEnumerable<IPropertySymbol> Properties { get; } = Properties;
    public IEnumerable<IMethodSymbol> PublicMethods { get; } = PublicMethods;
    public IEnumerable<INamedTypeSymbol> InheritsFromChain { get; } = InheritsFromChain;
    public string Category { get; set; } = Category;
    public string Subcategory { get; set; } = Subcategory;
    public string SearchUrl { get; set; } = SearchUrl;
    public string Summary { get; set; } = Summary;
}