import { ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { DeleteRequest } from "../Services/DeleteRequest";
import { DeleteResponse } from "../Services/DeleteResponse";
import { ListRequest } from "../Services/ListRequest";
import { ListResponse } from "../Services/ListResponse";
import { RetrieveRequest } from "../Services/RetrieveRequest";
import { RetrieveResponse } from "../Services/RetrieveResponse";
import { SaveRequest } from "../Services/SaveRequest";
import { SaveResponse } from "../Services/SaveResponse";
import { GenreRow } from "./GenreRow";

export namespace GenreService {
    export const baseUrl = 'Default/Genre';

    export declare function Create(request: SaveRequest<GenreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<GenreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<GenreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<GenreRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<GenreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<GenreRow>>;

    export const Methods = {
        Create: "Default/Genre/Create",
        Update: "Default/Genre/Update",
        Delete: "Default/Genre/Delete",
        Retrieve: "Default/Genre/Retrieve",
        List: "Default/Genre/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>GenreService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}