export interface Pagination{

    currentPage:number;
    itemsPerPage :number;
    totalItems :number;
    totalPages :number;
}

export class PaginatedResult<T>{
    result: T; //T Reseprent array of member "member[]
    pagination: Pagination;
}