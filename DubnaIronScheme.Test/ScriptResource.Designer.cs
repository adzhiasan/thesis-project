﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DubnaIronScheme.Test {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ScriptResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ScriptResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DubnaIronScheme.Test.ScriptResource", typeof(ScriptResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (get-val tree)
        ///    (car tree))
        ///(define (get-left tree)
        ///    (cadr tree))
        ///(define (get-right tree)
        ///    (caddr tree))
        ///(define (make-tree val left right)
        ///    (list val left right))
        ///
        ///(define (add-val-tree val tree)
        ///  (cond ((null? tree) (make-tree val &apos;() &apos;()))
        ///        ((&gt; val (get-val tree)) (make-tree (get-val tree) (get-left tree) (add-val-tree val (get-right tree))))
        ///        ((&lt; val (get-val tree)) (make-tree (get-val tree) (add-val-tree val (get-left tree)) (get-right tree) ))
        ///        ( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string add_list_tree {
            get {
                return ResourceManager.GetString("add-list-tree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (get-val tree)
        ///    (car tree))
        ///(define (get-left tree)
        ///    (cadr tree))
        ///(define (get-right tree)
        ///    (caddr tree))
        ///(define (make-tree val left right)
        ///    (list val left right))
        ///
        ///(define (add-val-tree val tree)
        ///  (cond ((null? tree) (make-tree val &apos;() &apos;()))
        ///        ((&gt; val (get-val tree)) (make-tree (get-val tree) (get-left tree) (add-val-tree val (get-right tree))))
        ///        ((&lt; val (get-val tree)) (make-tree (get-val tree) (add-val-tree val (get-left tree)) (get-right tree) ))
        ///        ( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string add_val_tree {
            get {
                return ResourceManager.GetString("add-val-tree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (cel-far temp dir)
        ///  (cond ((= dir 1)
        ///          (* (/ 5 9) (- temp 32.)) )
        ///        ((= dir 2)
        ///          (+ (* (/ 9 5) temp) 32.) )  ) ).
        /// </summary>
        internal static string cel_far {
            get {
                return ResourceManager.GetString("cel-far", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (getNlist n)
        ///  (define (getl n lis)
        ///    (cond ((= n 0) &apos;())
        ///          (else (cons lis (getl (- n 1) lis))) ) )
        ///  (getl n &apos;())
        ///).
        /// </summary>
        internal static string getNlist {
            get {
                return ResourceManager.GetString("getNlist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (in-predicate? a lis) 
        ///     (cond 
        ///        ((null? lis) #f) 
        ///        ((= a (car lis)) #t) 
        ///        (else (in-predicate? a (cdr lis))) 
        ///     ) 
        ///).
        /// </summary>
        internal static string in_predicate {
            get {
                return ResourceManager.GetString("in-predicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (get-val tree)
        ///    (car tree))
        ///(define (get-left tree)
        ///    (cadr tree))
        ///(define (get-right tree)
        ///    (caddr tree))
        ///(define (make-tree val left right)
        ///    (list val left right))
        ///
        ///(define (add-val-tree val tree)
        ///  (cond ((null? tree) (make-tree val &apos;() &apos;()))
        ///        ((&gt; val (get-val tree)) (make-tree (get-val tree) (get-left tree) (add-val-tree val (get-right tree))))
        ///        ((&lt; val (get-val tree)) (make-tree (get-val tree) (add-val-tree val (get-left tree)) (get-right tree) ))
        ///        ( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string leaf_tree {
            get {
                return ResourceManager.GetString("leaf-tree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (sci n pow)
        ///  (* n (expt 10 pow))).
        /// </summary>
        internal static string sci {
            get {
                return ResourceManager.GetString("sci", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (sumItems lis)
        ///  (if (null? lis) 
        ///      0
        ///      (+ (car lis) (sumItems (cdr lis)))
        ///  )
        ///).
        /// </summary>
        internal static string sumItems {
            get {
                return ResourceManager.GetString("sumItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (tip bill)
        ///  (- (ceiling (+ bill (* bill 0.15))) bill)).
        /// </summary>
        internal static string tip {
            get {
                return ResourceManager.GetString("tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (in-predicate? a lis) 
        ///     (cond 
        ///        ((null? lis) #f) 
        ///        ((= a (car lis)) #t) 
        ///        (else (in-predicate? a (cdr lis))) 
        ///     ) 
        ///)
        ///
        ///(define (union a b)
        ///    (cond 
        ///        ((null? a) b)
        ///        ((null? b) a)
        ///        ((in-predicate? (car a) b) (union (cdr a) b) )
        ///        (else (cons (car a) (union (cdr a) b)))
        ///    )
        ///).
        /// </summary>
        internal static string union {
            get {
                return ResourceManager.GetString("union", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (define (valid-date? d m y)
        ///  (cond ((or (&lt; d 1) (&lt; m 1) (&lt; y 1)) #f)
        ///        ((or (&gt; d 31) (&gt; m 12)) #f)
        ///        ((and (= d 31) (or (= m 2) (= m 4) (= m 6) (= m 9) (= m 11))) #f)
        ///        ((and (= d 30) (= m 2)) #f)
        ///        ((and (= d 29) (= m 2) (&gt; (modulo y 4) 0)) #f)
        ///        ((and (= d 29) (= m 2) (and (= (modulo y 100) 0) (&gt; (modulo y 400) 0))) #f)
        ///        (else #t))).
        /// </summary>
        internal static string valid_date {
            get {
                return ResourceManager.GetString("valid-date", resourceCulture);
            }
        }
    }
}
