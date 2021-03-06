//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.0.90
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;



namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>BazaarMaster</summary>
	[PublishedContentModel("BazaarMaster")]
	public partial class BazaarMaster : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarMaster";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarMaster(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarMaster, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>BazaarAccount</summary>
	[PublishedContentModel("BazaarAccount")]
	public partial class BazaarAccount : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarAccount";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarAccount(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarAccount, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarAccountHistory</summary>
	[PublishedContentModel("BazaarAccountHistory")]
	public partial class BazaarAccountHistory : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarAccountHistory";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarAccountHistory(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarAccountHistory, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarBasket</summary>
	[PublishedContentModel("BazaarBasket")]
	public partial class BazaarBasket : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarBasket";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarBasket(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarBasket, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarCheckout</summary>
	[PublishedContentModel("BazaarCheckout")]
	public partial class BazaarCheckout : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarCheckout";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarCheckout(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarCheckout, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarCheckoutConfirm</summary>
	[PublishedContentModel("BazaarCheckoutConfirm")]
	public partial class BazaarCheckoutConfirm : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarCheckoutConfirm";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarCheckoutConfirm(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarCheckoutConfirm, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarCheckoutShipping</summary>
	[PublishedContentModel("BazaarCheckoutShipping")]
	public partial class BazaarCheckoutShipping : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarCheckoutShipping";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarCheckoutShipping(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarCheckoutShipping, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarProduct</summary>
	[PublishedContentModel("BazaarProduct")]
	public partial class BazaarProduct : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarProduct";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarProduct(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarProduct, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Brief: A brief description used in the product listing
		///</summary>
		[ImplementPropertyType("brief")]
		public string Brief
		{
			get { return this.GetPropertyValue<string>("brief"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Merchello Product
		///</summary>
		[ImplementPropertyType("merchelloProduct")]
		public Merchello.Web.Models.ContentEditing.ProductDisplay MerchelloProduct
		{
			get { return this.GetPropertyValue<Merchello.Web.Models.ContentEditing.ProductDisplay>("merchelloProduct"); }
		}
	}

	/// <summary>BazaarProductCollection</summary>
	[PublishedContentModel("BazaarProductCollection")]
	public partial class BazaarProductCollection : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarProductCollection";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarProductCollection(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarProductCollection, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Products
		///</summary>
		[ImplementPropertyType("products")]
		public IEnumerable<Merchello.Web.Models.VirtualContent.IProductContent> Products
		{
			get { return this.GetPropertyValue<IEnumerable<Merchello.Web.Models.VirtualContent.IProductContent>>("products"); }
		}
	}

	/// <summary>BazaarProductContent</summary>
	[PublishedContentModel("BazaarProductContent")]
	public partial class BazaarProductContent : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarProductContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarProductContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarProductContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Description: The description of the product
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Image: An image for the product
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}

		///<summary>
		/// Overview
		///</summary>
		[ImplementPropertyType("overview")]
		public IHtmlString Overview
		{
			get { return this.GetPropertyValue<IHtmlString>("overview"); }
		}

		///<summary>
		/// Related Products
		///</summary>
		[ImplementPropertyType("relatedProducts")]
		public IEnumerable<Merchello.Web.Models.VirtualContent.IProductContent> RelatedProducts
		{
			get { return this.GetPropertyValue<IEnumerable<Merchello.Web.Models.VirtualContent.IProductContent>>("relatedProducts"); }
		}
	}

	/// <summary>BazaarProductGroup</summary>
	[PublishedContentModel("BazaarProductGroup")]
	public partial class BazaarProductGroup : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarProductGroup";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarProductGroup(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarProductGroup, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Brief
		///</summary>
		[ImplementPropertyType("brief")]
		public string Brief
		{
			get { return this.GetPropertyValue<string>("brief"); }
		}

		///<summary>
		/// Image
		///</summary>
		[ImplementPropertyType("image")]
		public Umbraco.Web.Models.ImageCropDataSet Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("image"); }
		}
	}

	/// <summary>BazaarReceipt</summary>
	[PublishedContentModel("BazaarReceipt")]
	public partial class BazaarReceipt : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarReceipt";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarReceipt(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarReceipt, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarRegistration</summary>
	[PublishedContentModel("BazaarRegistration")]
	public partial class BazaarRegistration : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarRegistration";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarRegistration(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarRegistration, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>BazaarStore</summary>
	[PublishedContentModel("BazaarStore")]
	public partial class BazaarStore : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarStore";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarStore(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarStore, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Enable Customer Accounts
		///</summary>
		[ImplementPropertyType("customerAccounts")]
		public bool CustomerAccounts
		{
			get { return this.GetPropertyValue<bool>("customerAccounts"); }
		}

		///<summary>
		/// Customer MemberType
		///</summary>
		[ImplementPropertyType("customerMemberType")]
		public object CustomerMemberType
		{
			get { return this.GetPropertyValue("customerMemberType"); }
		}

		///<summary>
		/// Enable wish list: This requires customer accounts to be enabled.
		///</summary>
		[ImplementPropertyType("enableWishList")]
		public bool EnableWishList
		{
			get { return this.GetPropertyValue<bool>("enableWishList"); }
		}

		///<summary>
		/// Featured Products
		///</summary>
		[ImplementPropertyType("featuredProducts")]
		public IEnumerable<Merchello.Web.Models.VirtualContent.IProductContent> FeaturedProducts
		{
			get { return this.GetPropertyValue<IEnumerable<Merchello.Web.Models.VirtualContent.IProductContent>>("featuredProducts"); }
		}

		///<summary>
		/// Overview
		///</summary>
		[ImplementPropertyType("overview")]
		public IHtmlString Overview
		{
			get { return this.GetPropertyValue<IHtmlString>("overview"); }
		}

		///<summary>
		/// Store Title
		///</summary>
		[ImplementPropertyType("storeTitle")]
		public string StoreTitle
		{
			get { return this.GetPropertyValue<string>("storeTitle"); }
		}

		///<summary>
		/// Theme Picker
		///</summary>
		[ImplementPropertyType("themePicker")]
		public object ThemePicker
		{
			get { return this.GetPropertyValue("themePicker"); }
		}
	}

	/// <summary>BazaarWishList</summary>
	[PublishedContentModel("BazaarWishList")]
	public partial class BazaarWishList : BazaarMaster
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BazaarWishList";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BazaarWishList(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BazaarWishList, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public object UmbracoBytes
		{
			get { return this.GetPropertyValue("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public object UmbracoExtension
		{
			get { return this.GetPropertyValue("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public object UmbracoHeight
		{
			get { return this.GetPropertyValue("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public object UmbracoWidth
		{
			get { return this.GetPropertyValue("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public object UmbracoBytes
		{
			get { return this.GetPropertyValue("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public object UmbracoExtension
		{
			get { return this.GetPropertyValue("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>MerchelloCustomer</summary>
	[PublishedContentModel("MerchelloCustomer")]
	public partial class MerchelloCustomer : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "MerchelloCustomer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public MerchelloCustomer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MerchelloCustomer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// First name
		///</summary>
		[ImplementPropertyType("firstName")]
		public string FirstName
		{
			get { return this.GetPropertyValue<string>("firstName"); }
		}

		///<summary>
		/// Last name
		///</summary>
		[ImplementPropertyType("lastName")]
		public string LastName
		{
			get { return this.GetPropertyValue<string>("lastName"); }
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public object UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public object UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public object UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public object UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public object UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public object UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public object UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public object UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public object UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public object UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public object UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public object UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
