import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { Pfk7103Row } from "./Pfk7103Row";

export namespace Pfk7103Service {
    export const baseUrl = 'Default/Pfk7103';

    export declare function Create(request: SaveRequest<Pfk7103Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<Pfk7103Row>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<Pfk7103Row>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<Pfk7103Row>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<Pfk7103Row>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<Pfk7103Row>>;

    export const Methods = {
        Create: "Default/Pfk7103/Create",
        Update: "Default/Pfk7103/Update",
        Delete: "Default/Pfk7103/Delete",
        Retrieve: "Default/Pfk7103/Retrieve",
        List: "Default/Pfk7103/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>Pfk7103Service)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}