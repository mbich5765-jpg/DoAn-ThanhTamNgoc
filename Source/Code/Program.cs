using Microsoft.EntityFrameworkCore;
using ThanhTamNgoc.Api.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
// 1. KẾT NỐI DATABASE: Đọc địa chỉ SQL từ appsettings.json và đăng ký vào hệ thống.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// 2. BẢO MẬT JWT TOKEN: Thiết lập khóa giải mã và các quy tắc kiểm tra Token (thời hạn, chữ ký).
var jwtKey = builder.Configuration["Jwt:Key"] ?? "Key_Mac_Dinh_Du_Dai_1234567890!";
var keyBytes = Encoding.UTF8.GetBytes(jwtKey);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(keyBytes)
        };
    });
// 3. XỬ LÝ LỖI JSON: Dùng IgnoreCycles để chặn lỗi lặp vòng vô hạn khi gửi dữ liệu Cha-Con về Front-end.
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// 4. CHẠY GIAO DIỆN WEB: Cấp quyền mở thư mục wwwroot và tự động chạy file index.html.
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
// 5. KÍCH HOẠT MIDDLEWARE: Bật tính năng kiểm tra đăng nhập, phân quyền và điều hướng API.
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();