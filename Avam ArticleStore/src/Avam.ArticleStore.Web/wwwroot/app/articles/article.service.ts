import {Injectable} from 'angular2/core';
import {Http,Response} from 'angular2/http';
import {IArticle, ITag} from './article';
import {Observable} from 'rxjs/Observable';

@Injectable()
export class ArticleService{
    //private dataUrl : string = '/data/articles.json';
    private dataUrl : string = '/api/articles';
    constructor(private _http: Http){
    }
    getEmptyArticle() : IArticle {
        return {
                    id:0,
                    title: '',
                    primaryTag: '',
                    //secondaryTags: '',
                    description: '',
                    briefBody:'',
                    addedOn: new Date(1900,1,1),
                    publishDate: new Date(1900,1,1),
                    sourceUrl:'',
                    author:''
                };
    }
    getArticle(id): Observable<IArticle>{
        let a = this.getArticles().map((articles: IArticle[])=>
                articles.find(article=>article.id==id));
                return a;
    }
    
    getArticles(): Observable<IArticle[]>{
        return this._http.get(this.dataUrl)
                    .map((response: Response)=><IArticle[]> response.json())
                    //.do(data=> console.log(JSON.stringify(data)))
                    .catch(this.handleError);
    }
    getTags() : Observable<ITag[]>{
        return this._http.get('/api/tags')
                    .map((response: Response)=><ITag[]> response.json())
                    //.do(data=> console.log(JSON.stringify(data)))
                    .catch(this.handleError);
    }
    saveArticle(article): Observable<IArticle>{
        return this._http.post(this.dataUrl + '/save',JSON.stringify(article))
                .map((response: Response)=> <IArticle>response.json())
                .catch(this.handleError);;
    }
    private handleError(error: Response){
        console.error(error);
        return Observable.throw(error.json().error || 'server error');
    }
}