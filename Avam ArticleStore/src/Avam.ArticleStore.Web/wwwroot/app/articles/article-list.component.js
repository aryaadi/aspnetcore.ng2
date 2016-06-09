System.register(['angular2/core', './article-component', './article.service', 'angular2/router'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, article_component_1, article_service_1, router_1;
    var ArticleListComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (article_component_1_1) {
                article_component_1 = article_component_1_1;
            },
            function (article_service_1_1) {
                article_service_1 = article_service_1_1;
            },
            function (router_1_1) {
                router_1 = router_1_1;
            }],
        execute: function() {
            ArticleListComponent = (function () {
                function ArticleListComponent(articleSvc) {
                    this.articleSvc = articleSvc;
                }
                ArticleListComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this.articleSvc.getArticles()
                        .subscribe(function (articles) { return _this.articles = articles; }, function (error) { return _this.error = error; });
                };
                ArticleListComponent = __decorate([
                    core_1.Component({
                        selector: 'article-list',
                        templateUrl: 'app/articles/article-list.component.html',
                        styleUrls: ['app/articles/app.component.css'],
                        directives: [article_component_1.ArticleComponent, router_1.ROUTER_DIRECTIVES]
                    }), 
                    __metadata('design:paramtypes', [article_service_1.ArticleService])
                ], ArticleListComponent);
                return ArticleListComponent;
            }());
            exports_1("ArticleListComponent", ArticleListComponent);
        }
    }
});
//# sourceMappingURL=article-list.component.js.map