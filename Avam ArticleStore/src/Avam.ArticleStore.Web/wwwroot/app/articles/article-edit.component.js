System.register(['angular2/core', 'angular2/common', './article.service', 'angular2/router'], function(exports_1, context_1) {
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
    var core_1, common_1, article_service_1, router_1;
    var ArticleAddEditComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (common_1_1) {
                common_1 = common_1_1;
            },
            function (article_service_1_1) {
                article_service_1 = article_service_1_1;
            },
            function (router_1_1) {
                router_1 = router_1_1;
            }],
        execute: function() {
            ArticleAddEditComponent = (function () {
                function ArticleAddEditComponent(_articleSvc, _routeParams, _router) {
                    this._articleSvc = _articleSvc;
                    this._routeParams = _routeParams;
                    this._router = _router;
                    this.pageTitle = "Loading...";
                    this.article = _articleSvc.getEmptyArticle();
                }
                ArticleAddEditComponent.prototype.ngOnInit = function () {
                    var _this = this;
                    this._articleSvc.getTags()
                        .subscribe(function (t) { return _this.tags = t; }, function (error) { return _this.errorMessage = error; });
                    var id = this._routeParams.get('id');
                    this.isNew = parseInt(id) <= 0;
                    if (!this.isNew) {
                        this._articleSvc.getArticle(id)
                            .subscribe(function (rtcl) { return _this.onArticleLoaded(rtcl); }, function (error) { return _this.errorMessage = error; });
                    }
                    else {
                        this.pageTitle = "New Article";
                    }
                };
                ArticleAddEditComponent.prototype.onArticleLoaded = function (article) {
                    this.article = article;
                    this.pageTitle = article.title + " [Edit]";
                };
                ArticleAddEditComponent.prototype.OnBack = function () {
                    this._router.navigate(['Articles']);
                };
                ArticleAddEditComponent.prototype.onSave = function () {
                    var _this = this;
                    console.log(this.article);
                    this._articleSvc.saveArticle(this.article)
                        .subscribe(function (art) { return _this.article = art; }, function (err) { return _this.errorMessage = err; });
                };
                ArticleAddEditComponent = __decorate([
                    core_1.Component({
                        templateUrl: 'app/articles/article-edit.component.html',
                        styleUrls: ['app/articles/app.component.css'],
                        directives: [common_1.NgClass]
                    }), 
                    __metadata('design:paramtypes', [article_service_1.ArticleService, router_1.RouteParams, router_1.Router])
                ], ArticleAddEditComponent);
                return ArticleAddEditComponent;
            }());
            exports_1("ArticleAddEditComponent", ArticleAddEditComponent);
        }
    }
});
//# sourceMappingURL=article-edit.component.js.map