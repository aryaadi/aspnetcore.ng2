export interface IArticle{
    id: number;
    title: string;
    primaryTag: string;
    //secondaryTags: string;
    description: string;
    briefBody: string;
    addedOn: Date;
    publishDate: Date;
    sourceUrl: string;
    author:string;
}
export interface ITag{
    id:number;
    name:string;
}