using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CalibreSmartServer.Message;


#region SubInfo




public class AuMap
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public object Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<object> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Authors
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("link_column")]
    public string LinkColumn { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class AuthorSort
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Comments
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Cover
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Display
{
    [JsonPropertyName("date_format")]
    public string DateFormat { get; set; }
}

public class FieldMetadata
{
    [JsonPropertyName("authors")]
    public Authors Authors { get; set; }

    [JsonPropertyName("languages")]
    public Languages Languages { get; set; }

    [JsonPropertyName("series")]
    public Series Series { get; set; }

    [JsonPropertyName("formats")]
    public Formats Formats { get; set; }

    [JsonPropertyName("publisher")]
    public Publisher Publisher { get; set; }

    [JsonPropertyName("rating")]
    public Rating Rating { get; set; }

    [JsonPropertyName("news")]
    public News News { get; set; }

    [JsonPropertyName("tags")]
    public Tags Tags { get; set; }

    [JsonPropertyName("identifiers")]
    public Identifiers Identifiers { get; set; }

    [JsonPropertyName("author_sort")]
    public AuthorSort AuthorSort { get; set; }

    [JsonPropertyName("au_map")]
    public AuMap AuMap { get; set; }

    [JsonPropertyName("comments")]
    public Comments Comments { get; set; }

    [JsonPropertyName("cover")]
    public Cover Cover { get; set; }

    [JsonPropertyName("id")]
    public Id Id { get; set; }

    [JsonPropertyName("last_modified")]
    public LastModified LastModified { get; set; }

    [JsonPropertyName("ondevice")]
    public Ondevice Ondevice { get; set; }

    [JsonPropertyName("path")]
    public Path Path { get; set; }

    [JsonPropertyName("pubdate")]
    public Pubdate Pubdate { get; set; }

    [JsonPropertyName("marked")]
    public Marked Marked { get; set; }

    [JsonPropertyName("in_tag_browser")]
    public InTagBrowser InTagBrowser { get; set; }

    [JsonPropertyName("series_index")]
    public SeriesIndex SeriesIndex { get; set; }

    [JsonPropertyName("series_sort")]
    public SeriesSort SeriesSort { get; set; }

    [JsonPropertyName("sort")]
    public Sort Sort { get; set; }

    [JsonPropertyName("size")]
    public Size Size { get; set; }

    [JsonPropertyName("timestamp")]
    public Timestamp Timestamp { get; set; }

    [JsonPropertyName("title")]
    public Title Title { get; set; }

    [JsonPropertyName("uuid")]
    public Uuid Uuid { get; set; }
}

public class Formats
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Id
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public object Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Identifiers
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class IdLinkRules
{
}

public class InTagBrowser
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public object Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class IsMultiple
{
    [JsonPropertyName("cache_to_list")]
    public string CacheToList { get; set; }

    [JsonPropertyName("ui_to_list")]
    public string UiToList { get; set; }

    [JsonPropertyName("list_to_ui")]
    public string ListToUi { get; set; }
}

public class Languages
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("link_column")]
    public string LinkColumn { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class LastModified
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Marked
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public object Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class News
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public object Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<object> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }
}

public class Ondevice
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class OtherInfo
{
    [JsonPropertyName("id_link_rules")]
    public IdLinkRules IdLinkRules { get; set; }
}

public class Path
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<object> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Pubdate
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Publisher
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("link_column")]
    public string LinkColumn { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Rating
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("link_column")]
    public string LinkColumn { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Series
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("link_column")]
    public string LinkColumn { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class SeriesIndex
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public object Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class SeriesSort
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Size
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Sort
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Tags
{
    [JsonPropertyName("table")]
    public string Table { get; set; }

    [JsonPropertyName("column")]
    public string Column { get; set; }

    [JsonPropertyName("link_column")]
    public string LinkColumn { get; set; }

    [JsonPropertyName("category_sort")]
    public string CategorySort { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Timestamp
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Title
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}

public class Uuid
{
    [JsonPropertyName("table")]
    public object Table { get; set; }

    [JsonPropertyName("column")]
    public object Column { get; set; }

    [JsonPropertyName("datatype")]
    public string Datatype { get; set; }

    [JsonPropertyName("is_multiple")]
    public IsMultiple IsMultiple { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("name")]
    public object Name { get; set; }

    [JsonPropertyName("search_terms")]
    public List<string> SearchTerms { get; set; }

    [JsonPropertyName("is_custom")]
    public bool IsCustom { get; set; }

    [JsonPropertyName("is_category")]
    public bool IsCategory { get; set; }

    [JsonPropertyName("is_csp")]
    public bool IsCsp { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("display")]
    public Display Display { get; set; }

    [JsonPropertyName("is_editable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("rec_index")]
    public int RecIndex { get; set; }
}


#endregion

public class SetLibraryInfoReq:IOperation<SetLibraryInfoReq>
{
    public static OperationType Op => OperationType.SET_LIBRARY_INFO;

    [JsonPropertyName("libraryName")]
    public string LibraryName { get; set; }

    [JsonPropertyName("libraryUuid")]
    public string LibraryUuid { get; set; }

    [JsonPropertyName("fieldMetadata")]
    public FieldMetadata FieldMetadata { get; set; }

    [JsonPropertyName("otherInfo")]
    public OtherInfo OtherInfo { get; set; }
}

public class SetLibraryInfoRes : IOperation<SetLibraryInfoRes>
{
    public static OperationType Op => OperationType.SET_LIBRARY_INFO;
}
