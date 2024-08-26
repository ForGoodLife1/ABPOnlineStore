using ABPCourse.Demo1;
using ABPOnlineStore.Products;
using ABPOnlineStore;
using FluentValidation;
using ABPCourse.Demo1.Products;

namespace ABPOnlineStore.ProductsAppService
{
    public class CreateUpdateProductValidator : AbstractValidator<CreateUpdateProductDto>
    {
        public CreateUpdateProductValidator()
        {
            RuleFor(x => x.NameAr)
                .NotEmpty()
                .MaximumLength(ABPOnlineStoreConsts.GenralTextMaxLength)
                .WithErrorCode(Demo1DomainErrorCodes.INVALID_PRODUCT_DATA_NAME_AR)
                .WithMessage("Product Name in Arabic is invalid");
            RuleFor(x => x.NameEn)
                .NotEmpty()
                .MaximumLength(ABPOnlineStoreConsts.GenralTextMaxLength)
                .WithErrorCode(Demo1DomainErrorCodes.INVALID_PRODUCT_DATA_NAME_EN)
                .WithMessage("Product Name in English is invalid");
            RuleFor(x => x.DescriptionAr)
                .NotEmpty()
                .MaximumLength(ABPOnlineStoreConsts.DescriptionTextMaxLength)
                .WithErrorCode(Demo1DomainErrorCodes.INVALID_PRODUCT_DATA_DESC_AR)
                .WithMessage("Product Description in Arabic is invalid");
            RuleFor(x => x.DescriptionEn)
                .NotEmpty()
                .MaximumLength(ABPOnlineStoreConsts.DescriptionTextMaxLength)
                .WithErrorCode(Demo1DomainErrorCodes.INVALID_PRODUCT_DATA_DESC_EN)
                .WithMessage("Product Description in English is invalid");
            RuleFor(x => x.CategoryId)
                .NotEmpty()
                .WithErrorCode(Demo1DomainErrorCodes.INVALID_PRODUCT_CATEGORY)
                .WithMessage("Product Category is invalid");
        }
    }
}