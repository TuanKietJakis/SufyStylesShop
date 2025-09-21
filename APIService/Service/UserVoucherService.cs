using BussinessObject.DTO.Comment;
using BussinessObject.DTO;
using Repositories.IRepository;
using Repositories.Repository;
using ISUZU_NEXT.Server.Core.Extentions;
using BussinessObject.DTO.UserVoucher;
using BussinessObject.DTO.Post;
using BussinessObject.Models;
using BussinessObject.Model;
using Repository.IRepository;
using Humanizer;

namespace APIService.Service
{
    public class UserVoucherService
    {
        private readonly IUserVoucherRepository _userVoucherRepository;
        private readonly IUserRepository _userRepository;
        public UserVoucherService(IUserVoucherRepository userVoucherRepository, IUserRepository userRepository)
        {
            _userVoucherRepository = userVoucherRepository;
            _userRepository = userRepository;
        }
        
        public async Task<PaginatedResponse<UserVoucherDto>> GetAllVouchers(PaginationParams paginationParams)
        {
            var entityPages = await _userVoucherRepository.GetPaginatedList(paginationParams);           
            var dtoPages = new PaginatedResponse<UserVoucherDto>();
            dtoPages.CopyProperties(entityPages);

            foreach (var dto in dtoPages.Items)
            {
                dto.CurrentUsage = (dto.MaxUsage ?? 0) - (dto.CurrentUsage ?? 0);         
            }

            return dtoPages;
        }
        public async Task<UserVoucherDto> CreateVoucher(UserVoucherCreateDto userVoucherCreateDto)
        {
            var admin = await _userRepository.GetUserById(userVoucherCreateDto.UserId);
            if (admin == null)
            {
                throw new Exception("Account not found");
            }

            var userVoucher = UserVoucher.Create(userVoucherCreateDto);

            _userVoucherRepository.Add(userVoucher);
            await _userVoucherRepository.SaveChanges();

            var userVoucherDto = new UserVoucherDto();
            userVoucherDto.CopyProperties(userVoucher);
            return userVoucherDto;
        }
        public async Task UpdateVoucher(UserVoucherUpdateDto dto)
        {
            var userVoucher = await _userVoucherRepository.GetById(dto.VoucherId);

            if (userVoucher == null)
            {
                throw new Exception("Voucher not found.");
            }

            userVoucher.Update(dto);

            _userVoucherRepository.Update(userVoucher);
            await _userVoucherRepository.SaveChanges();
        }
        public async Task UpdateStatus(Guid voucherId, bool status)
        {
            var userVoucher = await _userVoucherRepository.GetById(voucherId);

            if (userVoucher == null)
            {
                throw new Exception("Voucher not found.");
            }

            userVoucher.UpdateStatus(status);

            _userVoucherRepository.Update(userVoucher);
            await _userVoucherRepository.SaveChanges();
        }
    }
}
