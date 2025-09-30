# ASP.NET Core Static Website

A professional static website built with ASP.NET Core featuring responsive design, modern web standards, and cross-browser compatibility.

## 🚀 Features

- **ASP.NET Core 8.0 LTS** with minimal hosting model
- **Responsive Design** that works on all devices
- **Static File Serving** for HTML, CSS, and JavaScript
- **SEO Optimized** with comprehensive meta tags
- **Accessible Design** with ARIA labels and semantic HTML
- **Cross-Browser Compatible** (Chrome, Firefox, Safari, Edge)
- **Mobile-First Approach** with touch-friendly navigation
- **Contact Form** with client-side validation
- **Professional Styling** with modern CSS

## 📋 Pages Included

1. **Home** (`index.html`) - Welcome page with feature overview
2. **About** (`about.html`) - Detailed information about the platform
3. **Contact** (`contact.html`) - Contact form and information

## 🛠️ Technology Stack

- **Backend**: ASP.NET Core 8.0 (Minimal Hosting Model)
- **Frontend**: HTML5, CSS3, Vanilla JavaScript
- **Styling**: Responsive CSS with Grid and Flexbox
- **Build Tool**: .NET CLI
- **Containerization**: Docker support included

## 📁 Project Structure

```
/
├── Program.cs                 # ASP.NET Core application entry point
├── StaticWebsite.csproj      # Project file
├── Dockerfile                # Docker configuration
├── README.md                 # This file
└── wwwroot/                  # Static files directory
    ├── index.html            # Home page
    ├── about.html            # About page
    ├── contact.html          # Contact page
    ├── favicon.ico           # Website icon
    ├── css/
    │   └── styles.css        # Main stylesheet
    └── js/
        └── main.js           # JavaScript functionality
```

## 🔧 Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any modern web browser
- (Optional) [Docker](https://www.docker.com/) for containerization

## 🚀 Getting Started

### Local Development

1. **Clone or download the repository**
   ```bash
   # If using git
   git clone <repository-url>
   cd static-website
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Open your browser**
   - Navigate to `https://localhost:5001` or `http://localhost:5000`
   - The application will automatically open the home page

### Alternative: Using dotnet watch (for development)

For automatic reloading during development:
```bash
dotnet watch run
```

## 🐳 Docker Support

### Build Docker Image

```bash
docker build -t static-website .
```

### Run Docker Container

```bash
docker run -p 8080:8080 static-website
```

Then open `http://localhost:8080` in your browser.

## 🌐 Browser Compatibility

This website is tested and compatible with:

- **Chrome** 90+
- **Firefox** 88+
- **Safari** 14+
- **Edge** 90+
- **Mobile browsers** (iOS Safari, Chrome Mobile)

## 📱 Responsive Breakpoints

- **Desktop**: 1200px and above
- **Tablet**: 768px - 1199px
- **Mobile**: Below 768px

## ♿ Accessibility Features

- Semantic HTML5 markup
- ARIA labels and roles
- Keyboard navigation support
- Screen reader compatibility
- High contrast support
- Focus indicators

## 🔍 SEO Features

- Comprehensive meta tags
- Open Graph protocol support
- Twitter Card integration
- Semantic HTML structure
- Proper heading hierarchy
- Alt text for images (when applicable)

## 📝 Development Notes

### CSS Architecture

The CSS is organized with:
- **Reset styles** for cross-browser consistency
- **Base styles** for typography and layout
- **Component styles** for reusable elements
- **Responsive styles** with mobile-first approach
- **Utility classes** for common patterns

### JavaScript Features

- Mobile navigation toggle
- Form validation and submission handling
- Smooth scrolling for anchor links
- Intersection Observer for animations
- Current page highlighting in navigation

### Performance Optimizations

- Minimal CSS and JavaScript
- Efficient selectors and animations
- Preloaded critical resources
- Optimized images and assets
- Compressed and minified code (in production)

## 🔧 Customization

### Changing Colors

Edit the CSS custom properties in `wwwroot/css/styles.css`:
```css
:root {
  --primary-color: #3498db;
  --secondary-color: #2c3e50;
  --background-color: #f8f9fa;
}
```

### Adding New Pages

1. Create a new HTML file in `wwwroot/`
2. Follow the existing page structure
3. Update navigation in all pages
4. Add appropriate meta tags and SEO information

### Modifying Styles

The main stylesheet is located at `wwwroot/css/styles.css`. It uses:
- CSS Grid for layout
- Flexbox for component alignment
- CSS custom properties for theming
- Media queries for responsive design

## 🚀 Deployment

### IIS Deployment

1. Publish the application:
   ```bash
   dotnet publish -c Release -o ./publish
   ```

2. Copy the `publish` folder to your IIS server
3. Configure IIS to serve the application

### Azure App Service

1. Create an Azure App Service
2. Deploy using Visual Studio, Azure CLI, or GitHub Actions
3. Configure custom domain and SSL if needed

### Other Hosting Providers

The application can be deployed to any hosting provider that supports ASP.NET Core, including:
- Heroku
- AWS Elastic Beanstalk
- Google Cloud Platform
- DigitalOcean App Platform

## 🧪 Testing

### Manual Testing Checklist

- [ ] All pages load correctly
- [ ] Navigation works between pages
- [ ] Responsive design works on different screen sizes
- [ ] Contact form validation works
- [ ] Mobile menu toggles properly
- [ ] All links are functional
- [ ] No console errors
- [ ] Accessibility features work with screen readers

### Browser Testing

Test the website in multiple browsers and devices to ensure compatibility.

## 📄 License

This project is provided as a demonstration and learning resource. Feel free to use and modify as needed for your projects.

## 🤝 Contributing

This is a demonstration project, but suggestions and improvements are welcome:

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## 📞 Support

For questions or support regarding this ASP.NET Core static website:

- **Email**: info@staticwebsite.com
- **Documentation**: Check this README and code comments
- **Issues**: Create an issue in the repository

## 🔄 Version History

- **v1.0.0** - Initial release with all core features
  - ASP.NET Core 8.0 implementation
  - Responsive design
  - Three main pages (Home, About, Contact)
  - Contact form with validation
  - Docker support
  - Comprehensive documentation

---

**Built with ❤️ using ASP.NET Core**
